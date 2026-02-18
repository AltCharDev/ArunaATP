using _4RTools.Utils;
using _4RTools.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;

namespace _4RTools.Model
{
    internal class RevampedItemRenderer
    {

        private readonly int BUFFS_PER_ROW = 3;
        private readonly int DISTANCE_BETWEEN_CONTAINERS = 0;
        private readonly int DISTANCE_BETWEEN_ROWS = 52;
        private readonly int ICON_SPACING = 180;
        private readonly int DEBUFFS_Y_MARGIN = 35;
        private readonly int DEBUFFS_X_MARGIN_OFFSET = 0;
        private readonly int DEBUFFS_Y_MARGIN_OFFSET = 10;
        private readonly int LABEL_SIZE_WIDTH = 85;
        private readonly int LABEL_X_OFFSET = 6;
        private readonly int LABEL_Y_OFFSET = -11;
        private readonly Size LABEL_SIZE = new Size(80, 50);
        private readonly Size PICTUREBOX_SIZE = new Size(48, 48);
        private readonly Size TEXTBOX_SIZE = new Size(55, 20);
        private readonly int TEXTBOX_X_OFFSET = 35;
        private readonly int TEXTBOX_Y_OFFSET = 4;

        private readonly List<BuffContainer> _containers;
        private readonly ToolTip _toolTip;
        private string OldText = string.Empty;

        private string _modelName;

        public RevampedItemRenderer(string model, List<BuffContainer> containers, ToolTip toolTip)
        {
            this._modelName = model;
            this._containers = containers;
            this._toolTip = toolTip;
        }

        public void DoRender()
        {
            for (int i = 0; i < _containers.Count; i++)
            {
                BuffContainer bk = _containers[i];
                Point lastLocation = new Point(bk.container.Location.X + DEBUFFS_X_MARGIN_OFFSET, DEBUFFS_Y_MARGIN + DEBUFFS_Y_MARGIN_OFFSET);
                int colCount = 0;

                if (i > 0)
                {
                    //If not first container to be rendered, get last container height and append 70
                    bk.container.Location = new Point(_containers[i - 1].container.Location.X, _containers[i - 1].container.Location.Y + _containers[i - 1].container.Height + DISTANCE_BETWEEN_CONTAINERS);
                }

                foreach (Buff skill in bk.skills)
                {
                    Label label = new Label();
                    PictureBox pb = new PictureBox();
                    TextBox textBox = new TextBox();

                    label.BackgroundImageLayout = ImageLayout.Center;
                    label.Location = new Point(lastLocation.X + (colCount * ICON_SPACING) + LABEL_X_OFFSET, lastLocation.Y + LABEL_Y_OFFSET);
                    label.Name = "lbl" + ((int)skill.effectStatusID);
                    label.Size = LABEL_SIZE;
                    label.Text = skill.name;
                    label.TextAlign = ContentAlignment.MiddleRight;
                    _toolTip.SetToolTip(label, skill.name);

                    pb.Image = skill.icon;
                    pb.BackgroundImageLayout = ImageLayout.Center;
                    pb.Location = new Point(lastLocation.X + (colCount * ICON_SPACING) + LABEL_SIZE_WIDTH, lastLocation.Y);
                    pb.Name = "pbox" + ((int)skill.effectStatusID);
                    pb.Size = PICTUREBOX_SIZE;
                    _toolTip.SetToolTip(pb, skill.name);

                    textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
                    textBox.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
                    textBox.TextChanged += new EventHandler(OnTextChange);
                    textBox.Size = TEXTBOX_SIZE;
                    textBox.Tag = ((int)skill.effectStatusID);
                    textBox.Name = "in" + ((int)skill.effectStatusID);
                    textBox.Location = new Point(pb.Location.X + TEXTBOX_X_OFFSET, pb.Location.Y + TEXTBOX_Y_OFFSET);
                    textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    textBox.TextAlign = HorizontalAlignment.Center;

                    bk.container.Controls.Add(label);
                    bk.container.Controls.Add(textBox);
                    bk.container.Controls.Add(pb);

                    colCount++;

                    if (colCount == BUFFS_PER_ROW)
                    {
                        //5 Buffs per row
                        colCount = 0;
                        lastLocation = new Point(bk.container.Location.X + DEBUFFS_X_MARGIN_OFFSET, lastLocation.Y + DISTANCE_BETWEEN_ROWS);
                    }
                }
            }
        }

        private void OnTextChange(object sender, EventArgs e)
        {
            try
            {

                TextBox txtBox = (TextBox)sender;
                if (txtBox.Text.ToString() != String.Empty)
                {
                    Key key = (Key)Enum.Parse(typeof(Key), txtBox.Text.ToString());
                    EffectStatusIDs statusID = (EffectStatusIDs)Int16.Parse(txtBox.Name.Split(new[] { "in" }, StringSplitOptions.None)[1]);

                    switch (this._modelName)
                    {
                        case "Autobuff":
                            ProfileSingleton.GetCurrent().Autobuff.AddKeyToBuff(statusID, key);
                            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().Autobuff);
                            break;
                        case "DebuffsRecovery":
                            ProfileSingleton.GetCurrent().DebuffsRecovery.AddKeyToBuff(statusID, key);
                            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().DebuffsRecovery);
                            break;
                    }
                }
            }
            catch { }
        }


    }
}
