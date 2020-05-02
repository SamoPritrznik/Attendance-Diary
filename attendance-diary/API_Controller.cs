using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace attendance_diary
{
    public class Admins
    {
        public String id { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String email { get; set; }
        public String password { get; set; }

    }

    class API_Controller
    {
        public void getAllAdmins()
        {
            HttpClient clic = new HttpClient();

            clic.BaseAddress = new Uri($"https://attendance-diary.herokuapp.com/diary/admins");

            clic.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = clic.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {
                string dataObjects = response.Content.ReadAsStringAsync().Result;

                List<Admins> admin = JsonConvert.DeserializeObject<List<Admins>>(dataObjects);

                for (int x = 0; x < admin.Count; x++)
                {
                    Admins a = admin[x];
                    Console.WriteLine(a.name);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            clic.Dispose();
        }

        public async void newAdmin()
        {
            var admin = new Admins();
            admin.name = "luka";
            admin.surname = "lah";
            admin.email = "lah@gmail.com";
            admin.password = "1572456";

            var json = JsonConvert.SerializeObject(admin);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = $"https://attendance-diary.herokuapp.com/diary/admins";
            var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }


    }
}
