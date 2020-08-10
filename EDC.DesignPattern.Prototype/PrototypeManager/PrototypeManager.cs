using System.Collections.Generic;

namespace EDC.DesignPattern.Prototype
{
    public class PrototypeManager
    {
        private readonly Dictionary<string, OfficeDocument> dictOD = new Dictionary<string, OfficeDocument>();

        private PrototypeManager()
        {
            dictOD.Add("FAR", new FAR());
            dictOD.Add("SRS", new SRS());
        }

        public static PrototypeManager GetInstance()
        {
            return Nested.instance;
        }

        public void AddOfficeDocument(string key, OfficeDocument doc)
        {
            dictOD.Add(key, doc);
        }

        public OfficeDocument GetOfficeDocumentByKey(string key)
        {
            key = key.ToUpper();
            if (!dictOD.ContainsKey(key)) return null;

            return dictOD[key].Clone();
        }

        private class Nested
        {
            internal static readonly PrototypeManager instance = new PrototypeManager();

            static Nested()
            {
            }
        }
    }
}