using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoftGolfOverlayUI
{
    public partial class MeetingBG : Form
    {
        private Dictionary<string, string> scriptFileDict;
        public MeetingBG()
        {
            InitializeComponent();
            scriptFileDict = Program.retrieveDict();
            string bgImg = scriptFileDict["MeetingBGImg"];
            this.BackgroundImage = Image.FromFile(bgImg);
        }
    }
}
