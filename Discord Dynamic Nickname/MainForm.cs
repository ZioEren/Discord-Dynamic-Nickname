using System.Windows.Forms;
using Discord.Gateway;
using Discord;
using System;
using System.Threading;
public partial class MainForm : Form
{
    public DiscordSocketClient discordSocketClient;
    public Thread nickNameChanger;
    public int length = 1;
    public MainForm()
    {
        InitializeComponent();
        CheckForIllegalCrossThreadCalls = false;
    }
    private void button1_Click(object sender, System.EventArgs e)
    {
        try
        {
            new Thread(connectToDiscord).Start();
        }
        catch (Exception)
        {
        }
    }
    public void connectToDiscord()
    {
        try
        {
            discordSocketClient = new DiscordSocketClient();
            discordSocketClient.Login(textBox1.Text);
            MessageBox.Show("Succesfully connected to Discord!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            button2.Enabled = true;
        }
        catch (Exception)
        {
            MessageBox.Show("Failed to connect to Discord! The token is not valid or not verified.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            nickNameChanger = new Thread(doNickNameChanger);
            nickNameChanger.Start();
        }
        catch (Exception)
        {
        }
        button2.Enabled = false;
        button3.Enabled = true;
    }
    private void button3_Click(object sender, EventArgs e)
    {
        try
        {
            nickNameChanger.Abort();
        }
        catch (Exception)
        {
        }
        nickNameChanger = null;
        button3.Enabled = false;
        button2.Enabled = true;
    }
    public void doNickNameChanger()
    {
        while (true)
        {
            try
            {
                Thread.Sleep(750);
                if (length == textBox3.Text.Length + 1)
                {
                    length = 1;
                }
                string real = textBox3.Text.Substring(0, length);
                length++;
                discordSocketClient.GetGuild(ulong.Parse(textBox2.Text)).SetNicknameAsync(real);
            }
            catch (Exception)
            {
            }
        }
    }
}