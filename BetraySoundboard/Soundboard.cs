using System;
using System.Windows.Forms;


namespace BetraySoundboard
{
    public partial class Soundboard : Form
    {
        string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        
        string mergedPath;
        string play;

        int secret;

        public Soundboard()
        {
            InitializeComponent();
        }

        //Secret
        private void lbl1_Click(object sender, EventArgs e)
        {

            secret++;
            play = @"\BetraySoundboard\BetraySoundboard\resources\sounds\secret.wav"; // \BetraySoundboard\BetraySoundboard\ for release
            mergedPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appPath, @"..\") + play); //2 ..\ for debug, 1 release
            System.Media.SoundPlayer playsound = new System.Media.SoundPlayer(mergedPath);

            playsound.Play();
            if (secret == 10)
            {
                System.Diagnostics.Process.Start("http://flappycreator.com/flappy.php?id=532e0477c4ba5");
                secret = 0;
            }
        }

        //Line 1
        private void btn1_Click(object sender, EventArgs e)
        {
            string playString = btn1.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            string playString = btn2.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            string playString = btn3.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            string playString = btn4.Name;

            playString = PlaySoundMethod(playString);
        }

        //Line 2
        private void btn5_Click(object sender, EventArgs e)
        {
            string playString = btn5.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            string playString = btn6.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            string playString = btn7.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            string playString = btn8.Name;

            playString = PlaySoundMethod(playString);
        }

        //Line 3
        private void btn9_Click(object sender, EventArgs e)
        {
            string playString = btn9.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            string playString = btn10.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn11_Click(object sender, EventArgs e)
        {
            string playString = btn11.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn12_Click(object sender, EventArgs e)
        {
            string playString = btn12.Name;

            playString = PlaySoundMethod(playString);
        }

        //Line 4
        private void btn13_Click(object sender, EventArgs e)
        {
            string playString = btn13.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn14_Click(object sender, EventArgs e)
        {
            string playString = btn14.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn15_Click(object sender, EventArgs e)
        {
            string playString = btn15.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn16_Click(object sender, EventArgs e)
        {
            string playString = btn16.Name;

            playString = PlaySoundMethod(playString);
        }

        //Line 5
        private void btn17_Click(object sender, EventArgs e)
        {
            string playString = btn17.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn18_Click(object sender, EventArgs e)
        {
            string playString = btn18.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn19_Click(object sender, EventArgs e)
        {
            string playString = btn19.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn20_Click(object sender, EventArgs e)
        {
            string playString = btn20.Name;

            playString = PlaySoundMethod(playString);
        }

        //Line 6
        private void btn21_Click(object sender, EventArgs e)
        {
            string playString = btn21.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn22_Click(object sender, EventArgs e)
        {
            string playString = btn22.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn23_Click(object sender, EventArgs e)
        {
            string playString = btn23.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn24_Click(object sender, EventArgs e)
        {
            string playString = btn24.Name;

            playString = PlaySoundMethod(playString);
        }

        //Line 7
        private void btn25_Click(object sender, EventArgs e)
        {
            string playString = btn25.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn26_Click(object sender, EventArgs e)
        {
            string playString = btn26.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn27_Click(object sender, EventArgs e)
        {
            string playString = btn27.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn28_Click(object sender, EventArgs e)
        {
            string playString = btn28.Name;

            playString = PlaySoundMethod(playString);
        }

        //Line 8
        private void btn29_Click(object sender, EventArgs e)
        {
            string playString = btn29.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn30_Click(object sender, EventArgs e)
        {
            string playString = btn30.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn31_Click(object sender, EventArgs e)
        {
            string playString = btn31.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn32_Click(object sender, EventArgs e)
        {
            string playString = btn32.Name;

            playString = PlaySoundMethod(playString);
        }

        //Line 9
        private void btn33_Click(object sender, EventArgs e)
        {
            string playString = btn33.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn34_Click(object sender, EventArgs e)
        {
            string playString = btn34.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn35_Click(object sender, EventArgs e)
        {
            string playString = btn35.Name;

            playString = PlaySoundMethod(playString);
        }
        private void btn36_Click(object sender, EventArgs e)
        {
            string playString = btn36.Name;

            playString = PlaySoundMethod(playString);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help HelpForm = new Help(); //Opens the Help menu
            HelpForm.ShowDialog();
        }

        private string PlaySoundMethod(string playString)
        {
            var charsToRemove = new string[] { "b", "t", "n" };
            foreach (var c in charsToRemove)
            {
                playString = playString.Replace(c, string.Empty);
            }

            play = @"\BetraySoundboard\BetraySoundboard\resources\sounds\" + playString + ".wav"; // \BetraySoundboard\BetraySoundboard\ for release
            mergedPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appPath, @"..\") + play); //2 ..\ for debug, 1 release
            System.Media.SoundPlayer playsound = new System.Media.SoundPlayer(mergedPath);

            if (chk1.Checked)
            {
                playsound.PlayLooping();
            }

            if (!chk1.Checked)
            {
                playsound.Play();
            }

            return playString;
        }
    }
}