using System.Net.NetworkInformation;
using System.Text;

//Pinging Google DNS server 4.2.2.2

Ping pingSender = new Ping();

PingOptions options = new PingOptions();

options.DontFragment = true;

string data = "Learn to code";

//Needs to be buffered
byte[] buffer = Encoding.ASCII.GetBytes(data);

int timeout = 120;





