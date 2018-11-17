namespace AssetPacker.Command
{
    public class BMFontAutoConvert : ICommand
    {
        private MainForm form;

        public BMFontAutoConvert(MainForm form)
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
        }
    }
}
