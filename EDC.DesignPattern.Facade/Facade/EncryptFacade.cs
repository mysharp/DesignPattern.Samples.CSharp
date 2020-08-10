namespace EDC.DesignPattern.Facade
{
    public class EncryptFacade
    {
        private readonly CipherMachine cipher;
        private readonly FileReader reader;
        private readonly FileWriter writer;

        public EncryptFacade()
        {
            reader = new FileReader();
            cipher = new CipherMachine();
            writer = new FileWriter();
        }

        public void FileEncrypt(string fileNameSrc, string fileNameDes)
        {
            var plainStr = reader.Read(fileNameSrc);
            var encryptedStr = cipher.Encrypt(plainStr);
            writer.Write(encryptedStr, fileNameDes);
        }
    }
}