namespace AssetPacker.Command
{
    public class OpenASCIIForm : ICommand
    {
        private MainForm form;

        public OpenASCIIForm(MainForm form)
        {
            this.form = form;
        }

        public bool Check()
        {
            return true;
        }

        public void Execute()
        {
            if (!Check())
                return;

            ASCIIForm ASCIIForm = new ASCIIForm();
            ASCIIForm.Show();
        }
    }
}
