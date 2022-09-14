using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace cobalogin
{
    //abstract class for JSON instance
    public class input 
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public int LengthUser, LengthPassword;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Simple Example of marshal and unarshal concept on login. 
             * in this example i'm not using any database for login implemantation on server side. in this code example just showing the flow
             * of serialization and deserialization using newtonsoft library*/

            //taking input from a Form design
            string username = textboxUser.Text;
            string password = textboxPass.Text;
            int userlen = username.Length;
            int passlen = password.Length;

            // instance from input class to serialize input into JSON
            input clientinput = new input()
            {
                Username = username,
                Password = password,
                LengthUser= userlen,
                LengthPassword= passlen
            };
            var clientinputjson = JsonConvert.SerializeObject(clientinput);

            Console.WriteLine("Serialize JSON : ");
            Console.WriteLine(clientinputjson);

            //deserialized json
            var jsonstring = clientinputjson;
            var DeserializedInput = JsonConvert.DeserializeObject<input>(jsonstring);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textboxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
