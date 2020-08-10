namespace EDC.DesignPattern.Facade
{
    public class NewEncryptFacade : AbstractEncryptFacade
    {
        private readonly NewCipherMachine cipher;
        private readonly FileReader reader;
        private readonly FileWriter writer;

        public NewEncryptFacade()
        {
            reader = new FileReader();
            cipher = new NewCipherMachine();
            writer = new FileWriter();
        }

        public override void FileEncrypt(string fileNameSrc, string fileNameDes)
        {
            var plainStr = reader.Read(fileNameSrc);
            var encryptedStr = cipher.Encrypt(plainStr);
            writer.Write(encryptedStr, fileNameDes);
        }
    }
}