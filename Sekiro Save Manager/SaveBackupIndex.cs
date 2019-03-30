using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace Sekiro_Save_Manager
{
    internal class SaveBackupIndex : IEnumerable<SaveBackup>
    {
        private const string FMT = "O"; // preserve timezone information
        private readonly List<SaveBackup> _profiles = new List<SaveBackup>();

        public void Add(SaveBackup profile)
        {
            _profiles.Add(profile);
        }

        public bool Remove(SaveBackup profile)
        {
            return _profiles.Remove(profile);
        }

        public void Load(string fileName)
        {
            _profiles.Clear();

            var doc = new XmlDocument();
            doc.Load(fileName);

            foreach (XmlNode node in doc.DocumentElement)
            {
                var profile = new SaveBackup(node.SelectSingleNode("backup_location").InnerText,
                    node.SelectSingleNode("source_location").InnerText,
                    node.SelectSingleNode("comment").InnerText,
                    DateTime.ParseExact(node.SelectSingleNode("date").InnerText, FMT, CultureInfo.InvariantCulture));

                _profiles.Add(profile);
            }
        }

        public void Save(string fileName)
        {
            var xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("profiles");
            xmlDoc.AppendChild(rootNode);

            XmlNode profileNode = xmlDoc.CreateElement("profile");
            rootNode.AppendChild(profileNode);

            foreach (var profile in _profiles)
            {
                XmlNode backupNode = xmlDoc.CreateElement("backup_location");
                backupNode.InnerText = profile.BackupLocation;
                profileNode.AppendChild(backupNode);

                XmlNode sourceNode = xmlDoc.CreateElement("source_location");
                sourceNode.InnerText = profile.SourceLocation;
                profileNode.AppendChild(sourceNode);

                XmlNode commentNode = xmlDoc.CreateElement("comment");
                commentNode.InnerText = profile.Comment;
                profileNode.AppendChild(commentNode);

                XmlNode dateNode = xmlDoc.CreateElement("date");
                dateNode.InnerText = profile.Saved.ToString(FMT);
                profileNode.AppendChild(dateNode);
            }


            xmlDoc.Save(fileName);
        }

        #region Implementation of IEnumerable

        public IEnumerator<SaveBackup> GetEnumerator()
        {
            return _profiles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}