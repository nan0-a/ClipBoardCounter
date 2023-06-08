using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardCounter
{
    public partial class FormClipBoardCount : Form
    {
        public FormClipBoardCount()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void FormClipboardCounterLoad(object sender, EventArgs e)
        {
            this.TopMost = true;
            ClipboardCheckFireTick(null, null);
        }

        private void ClipboardCheckFireTick(object sender, EventArgs e)
        {
            string cboard_cont, cboard_cont_noline;
            int cboard_cont_byte;
            IDataObject data = Clipboard.GetDataObject();

            if (data.GetDataPresent(DataFormats.Text))
            {
                cboard_cont = (string)data.GetData(DataFormats.Text);

                //CRLFをLFに置換
                cboard_cont = cboard_cont.Replace("\r\n", "\n");
                cboard_cont_noline = cboard_cont.Replace("\n", "");

                //文字コードをShift-JISとしてバイト数を取得する
                Encoding encShiftJis = Encoding.GetEncoding("Shift_JIS");
                cboard_cont_byte = encShiftJis.GetByteCount(cboard_cont);

                int threads = (int)Math.Ceiling((double)cboard_cont_byte / 280),
                    bytes_left = cboard_cont_byte % 280 > 0 ? 280 - cboard_cont_byte % 280 : 0;

                // char_count_label.Text = "Chars: " + cboard_cont.Length.ToString() 
                // + "\nChars(w/o \\n): " + cboard_cont_noline.Length.ToString()
                // + "\nTwitter: " + threads.ToString()
                // + "(-" + bytes_left.ToString() + "B)";

                char_count_label.Text = cboard_cont.Length.ToString()
                    + " : " + cboard_cont_noline.Length.ToString()
                    + " : " + threads.ToString()
                    + " : -" + bytes_left.ToString() + "B";
            }
            else
            {
                char_count_label.Text = "Not A Text";
            }
        }
    }
}
