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
        public String _id { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String email { get; set; }
        public String password { get; set; }

    }

    public class Time
    {
        public String _id { get; set; }
        public String admin_id { get; set; }
        public String worker_id { get; set; }
        public String construction_id { get; set; }
        public string Timestamp_date { get; set; }
        public int Shift { get; set; }

    }

    public class Workers
    {
        public String _id { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String phone_num { get; set; }

    }

    public class Constructions
    {
        public String _id { get; set; }
        public String location { get; set; }
        public String site_name { get; set; }
        public Boolean used { get; set; }

    }

    class API_Controller
    {
       

        public string getAllWorkers()
        {
            HttpClient clic = new HttpClient();

            clic.BaseAddress = new Uri($"https://attendance-diary.herokuapp.com/diary/workers");

            clic.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = clic.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {
                string dataObjects = response.Content.ReadAsStringAsync().Result;
                return dataObjects;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            clic.Dispose();
            string lel = "";
            return lel;
        }

        public string getAllConstructions()
        {
            HttpClient clic = new HttpClient();

            clic.BaseAddress = new Uri($"https://attendance-diary.herokuapp.com/diary/constructions");

            clic.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = clic.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {
                string dataObjects = response.Content.ReadAsStringAsync().Result;
                return dataObjects;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            clic.Dispose();
            string lel = "";
            return lel;
        }

        public string getWorkerId(string dataObjects, string name, string surname)
        {
            List<Admins> admins = JsonConvert.DeserializeObject<List<Admins>>(dataObjects);

            for (int x = 0; x < admins.Count; x++)
            {
                Admins a = admins[x];
                if(a.name == name && a.surname == surname)
                {
                    return a._id;
                }
            }

            return "";
        }

        public string getConstructionsId(string dataObjects, string site_name)
        {
            List<Constructions> constructions = JsonConvert.DeserializeObject<List<Constructions>>(dataObjects);

            for (int x = 0; x < constructions.Count; x++)
            {
                Constructions a = constructions[x];
                if (a.site_name == site_name)
                {
                    return a._id;
                }
            }

            return "";
        }

        public List<String> ConstructionsToCmb(string dataObjects)
        {
            List<Constructions> constructions = JsonConvert.DeserializeObject<List<Constructions>>(dataObjects);
            List<String> listek = new List<String>();

            for (int x = 0; x < constructions.Count; x++)
            {
                Constructions a = constructions[x];

                listek.Add(a.site_name);
            }

            return listek;
        }

        public List<String> WorkersToCmb(string dataObjects)
        {
            List<Workers> workers = JsonConvert.DeserializeObject<List<Workers>>(dataObjects);
            List<String> listek = new List<String>();

            for (int x = 0; x < workers.Count; x++)
            {
                Workers a = workers[x];

                listek.Add(a.name + " " + a.surname);
            }

            return listek;
        }

        public List<String> AdminsToCmb(string dataObjects)
        {
            List<Admins> admins = JsonConvert.DeserializeObject<List<Admins>>(dataObjects);
            List<String> listek = new List<String>();

            for (int x = 0; x < admins.Count; x++)
            {
                Admins a = admins[x];

                listek.Add(a.name + " " + a.surname);
            }

            return listek;
        }

        public async void insertConstruction(string location, string site_name, Boolean used)
        {
            var construction = new Constructions();
            construction.location = location;
            construction.site_name = site_name;
            construction.used = used;

            var json = JsonConvert.SerializeObject(construction);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = $"https://attendance-diary.herokuapp.com/diary/constructions";
            var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }

        public async void updateConstruction(string location, string site_name, Boolean used, string odl_site, string dataObjects)
        {
            List<Constructions> constructions = JsonConvert.DeserializeObject<List<Constructions>>(dataObjects);

            for (int x = 0; x < constructions.Count(); x++)
            {
                if (constructions[x].site_name == odl_site)
                {
                    constructions[x].location = location;
                    constructions[x].site_name = site_name;
                    constructions[x].used = used;

                    var json = JsonConvert.SerializeObject(constructions[x]);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");

                    var url = $"https://attendance-diary.herokuapp.com/diary/constructions/{constructions[x]._id}";
                    var client = new HttpClient();

                    var response = await client.PutAsync(url, data);

                    string result = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(result);
                    break;
                }
            }
        }

        public async void insertWorker(string name, string sur, string phone)
        {
            var worker = new Workers();
            worker.name = name;
            worker.surname = sur;
            worker.phone_num = phone;

            var json = JsonConvert.SerializeObject(worker);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = $"https://attendance-diary.herokuapp.com/diary/workers";
            var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }

        public async void updateWorker(string name, string sur, string phone, string old_name, string old_surname, string dataObjects)
        {
            List<Workers> workers = JsonConvert.DeserializeObject<List<Workers>>(dataObjects);

            for (int x = 0; x < workers.Count(); x++)
            {
                if (workers[x].name == old_name && workers[x].surname == old_surname)
                {
                    workers[x].name = name;
                    workers[x].surname = sur;
                    workers[x].phone_num = phone;

                    var json = JsonConvert.SerializeObject(workers[x]);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");

                    var url = $"https://attendance-diary.herokuapp.com/diary/workers/{workers[x]._id}";
                    var client = new HttpClient();

                    var response = await client.PutAsync(url, data);

                    string result = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(result);
                }
            }
        }

        public async void insertAdmin(string name, string sur, string email, string pass)
        {
            var admin = new Admins();
            admin.name = name;
            admin.surname = sur;
            admin.email = email;
            admin.password = pass;

            var json = JsonConvert.SerializeObject(admin);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = $"https://attendance-diary.herokuapp.com/diary/admins";
            var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);

        }

        public async void updateAdmin(string name, string sur, string email, string pass, string old_name, string old_surname, string dataObjects)
        {
            List<Admins> admins = JsonConvert.DeserializeObject<List<Admins>>(dataObjects);

            for (int x = 0; x < admins.Count(); x++)
            {
                if(admins[x].name == old_name && admins[x].surname == old_surname)
                {
                    admins[x].name = name;
                    admins[x].surname = sur;
                    admins[x].email = email;
                    admins[x].password = pass;

                    var json = JsonConvert.SerializeObject(admins[x]);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");

                    var url = $"https://attendance-diary.herokuapp.com/diary/admins/{admins[x]._id}";
                    var client = new HttpClient();

                    var response = await client.PutAsync(url, data);

                    string result = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(result);
                }
            }
        }

        public string getAllAdmins()
        {
            HttpClient clic = new HttpClient();

            clic.BaseAddress = new Uri($"https://attendance-diary.herokuapp.com/diary/admins");

            clic.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = clic.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {
                string dataObjects = response.Content.ReadAsStringAsync().Result;
                return dataObjects;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            clic.Dispose();
            string lel = "";
            return lel;
        }

        public Boolean logInAdmin(string dataObjects, string email, string password)
        {
            List<Admins> admins = JsonConvert.DeserializeObject<List<Admins>>(dataObjects);

            for (int x = 0; x < admins.Count; x++)
            {
                Admins a = admins[x];
                if (a.email == email && a.password == password)
                {
                    Admin_menu am = new Admin_menu(a._id);
                    am.Show();
                    return true;
                }
            }
            MessageBox.Show("Napačni email ali pa geslo");
            return false;
        }


        public async void addTime(string admin_id, string worker_id, string construction_id, int Shift, string Timestamp_date)
        {
            var time = new Time();
            time.admin_id = admin_id;
            time.worker_id = worker_id;
            time.construction_id = construction_id;
            time.Timestamp_date = Timestamp_date;
            time.Shift = Shift;

            var json = JsonConvert.SerializeObject(time);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = $"https://attendance-diary.herokuapp.com/diary/time";
            var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
            
        }
    }
}
