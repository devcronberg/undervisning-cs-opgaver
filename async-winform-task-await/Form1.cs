using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async_winform_task_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CancellationTokenSource tokenSource = new CancellationTokenSource();

        private async void BtnAwait_Click(object sender, EventArgs e)
        {
            try
            {
                btnAwait.Enabled = false;
                btnAwaitAfbryd.Enabled = true;
                txtTal.Text = "";
                Repository r = new Repository();
                int t = await r.HentTilfældigVærdi(tokenSource.Token, chkSimulerFejl.Checked);
                txtTal.Text = t.ToString();
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show(ex.Message, "Afbryd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fejl");
            }
            finally {
                btnAwait.Enabled = true;
                btnAwaitAfbryd.Enabled = false;
            }
        }

        private void BtnAwaitAfbryd_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            tokenSource = new CancellationTokenSource();
        }
    }
}
