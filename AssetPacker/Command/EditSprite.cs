namespace AssetPacker.Command
{
    public class EditSprite : ICommand
    {
        private MainForm form;

        public EditSprite(MainForm form)
        {
            this.form = form;
        }

        public bool Check()
        {
            return form.listAssets.SelectedIndices.Count > 0;
        }

        public void Execute()
        {
            if (!Check())
                return;

            if (form.listAssets.SelectedIndices.Count == 0)
                return;

            Model.Asset asset = form.project.Assets[form.listAssets.SelectedIndices[0]];
            SpriteForm spriteForm = new SpriteForm()
            {
                Atlas = asset.Atlas
            };
            spriteForm.UpdateList();
            spriteForm.ShowDialog(form);

            form.dirty = true;
            form.UpdateTitle();
        }
    }
}
