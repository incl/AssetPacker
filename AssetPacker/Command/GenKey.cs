namespace AssetPacker.Command
{
    public class GenKey : ICommand
    {
        private MainForm form;

        public GenKey(MainForm form)
        {
            this.form = form;
        }

        public bool Check()
        {
            return form.project != null;
        }

        public void Execute()
        {
            if (!Check())
                return;

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*()_+-=";
            var stringChars = new char[64];
            var random = new System.Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            form.txtPrivateKey.Text = new System.String(stringChars);
        }
    }
}
