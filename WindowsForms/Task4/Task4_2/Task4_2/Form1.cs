using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Task4_2
{
    public partial class MainForm : Form
    {
        Random r;

        delegate Control createControlDelegate();

        List<createControlDelegate> creationMethods;
        ArrayList createdControls;

        public MainForm()
        {
            InitializeComponent();

            creationMethods = new List<createControlDelegate>();
            creationMethods.Add(new createControlDelegate(createLabel));
            creationMethods.Add(new createControlDelegate(createButton));
            creationMethods.Add(new createControlDelegate(createTextBox));
            creationMethods.Add(new createControlDelegate(createComboBox));
            creationMethods.Add(new createControlDelegate(createListBox));

            createdControls = new ArrayList();
            for (int i = 0; i < creationMethods.Count; ++i)
            {
                createdControls.Add(new object());
            }

            r = new Random((int)DateTime.Now.Ticks);
        }

        private Control createLabel()
        {
            Label result = new Label();
            result.Location = new Point(0, 0);
            result.Size = new Size(r.Next(100, 150), r.Next(50, 100));
            result.Text = "Label :)";
            result.Font = new Font(FontFamily.GenericSerif, Math.Min(result.Size.Width, result.Size.Height) / 4);

            return result;
        }

        private Control createButton()
        {
            Button result = new Button();
            result.Location = new Point(0, 0);
            result.Size = new Size(r.Next(150, 200), r.Next(50, 100));
            result.Text = "Button :)";
            result.Font = new Font(FontFamily.GenericMonospace, Math.Min(result.Size.Width, result.Size.Height) / 4);

            return result;
        }

        private Control createTextBox()
        {
            TextBox result = new TextBox();
            result.Location = new Point(0, 0);
            result.Size = new Size(r.Next(150, 200), r.Next(50, 100));
            result.Text = "Text Box :)";
            result.Font = new Font(FontFamily.GenericSansSerif, Math.Min(result.Size.Width, result.Size.Height));

            return result;
        }

        private Control createComboBox()
        {
            ComboBox result = new ComboBox();
            result.Location = new Point(0, 0);
            result.Size = new Size(r.Next(150, 200), r.Next(50, 100));
            result.Items.Add("This");
            result.Items.Add("is");
            result.Items.Add("ComboBox");
            result.Items.Add(":)");
            result.Text = "Click me";
            result.Font = new Font(FontFamily.GenericSansSerif, Math.Min(result.Size.Width, result.Size.Height));

            return result;
        }

        private Control createListBox()
        {
            ListBox result = new ListBox();
            result.Location = new Point(0, 0);
            result.Size = new Size(r.Next(150, 200), r.Next(150, 200));
            result.Items.Add("This");
            result.Items.Add("is");
            result.Items.Add("ListBox");
            result.Items.Add(":)");
            result.ForeColor = Color.Green;
            result.Font = new Font(FontFamily.GenericSansSerif, 14);

            return result;
        }

        private void controlsToCreateCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                int selectedIndex = controlsToCreateCheckedListBox.SelectedIndex;
                Control newControl = creationMethods[selectedIndex]();
                createdControls[selectedIndex] = newControl;

                newControl.Location = new Point(r.Next(previewGroupBox.Size.Width - newControl.Size.Width), r.Next(previewGroupBox.Size.Height - newControl.Size.Height));

                this.previewGroupBox.Controls.Add(newControl);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                int selectedIndex = controlsToCreateCheckedListBox.SelectedIndex;
                this.previewGroupBox.Controls.Remove((Control)createdControls[selectedIndex]);
            }
        }
    }
}
