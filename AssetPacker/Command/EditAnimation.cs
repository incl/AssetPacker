using System.Collections.Generic;

namespace AssetPacker.Command
{
    public class EditAnimation : ICommand
    {
        private MainForm form;

        public EditAnimation(MainForm form)
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

            Model.Asset asset = form.project.Assets[form.listAssets.SelectedIndices[0]];
            if (asset.Atlas == null)
                return;
            
            AnimationForm aniForm = new AnimationForm();
            aniForm.SetData(form.project, asset);
            aniForm.ShowDialog();

            form.dirty = true;
            form.UpdateTitle();
        }
    }
}
