using System.Collections.Generic;
using Newtonsoft.Json;

public static class Data {
  public static string JSON = "[{'id':1,'from':'Graz','to':'Mallorca','date':'2021-05-24T08:10:54.0224822+00:00','delayed':false},{'id':2,'from':'Graz','to':'Hamburg','date':'2021-05-21T08:10:54.0224822+00:00','delayed':false},{'id':3,'from':'Hamburg','to':'Graz','date':'2021-05-21T09:10:54.0224822+00:00','delayed':false},{'id':4,'from':'Hamburg','to':'Graz','date':'2021-05-21T11:10:54.0224822+00:00','delayed':false},{'id':5,'from':'Hamburg','to':'Graz','date':'2021-05-21T14:10:54.0224822+00:00','delayed':false},{'id':6,'from':'Wien','to':'Berlin','date':'2021-05-21T14:10:54.0224822+00:00','delayed':false},{'id':7,'from':'Wien','to':'Berlin','date':'2021-05-21T15:10:54.0224822+00:00','delayed':false},{'id':8,'from':'Wien','to':'Berlin','date':'2021-05-21T16:10:54.0224822+00:00','delayed':false},{'id':9,'from':'Wien','to':'München','date':'2021-05-21T17:10:54.0224822+00:00','delayed':false},{'id':10,'from':'Wien','to':'München','date':'2021-05-21T18:10:54.0224822+00:00','delayed':false},{'id':11,'from':'Wien','to':'München','date':'2021-05-21T19:10:54.0224822+00:00','delayed':false},{'id':12,'from':'Wien','to':'Zürich','date':'2021-05-21T20:10:54.0224822+00:00','delayed':false},{'id':13,'from':'Wien','to':'Zürich','date':'2021-05-21T21:10:54.0224822+00:00','delayed':false},{'id':14,'from':'Wien','to':'Zürich','date':'2021-05-21T22:10:54.0224822+00:00','delayed':false},{'id':15,'from':'Wien','to':'Bern','date':'2021-05-21T23:10:54.0224822+00:00','delayed':false},{'id':16,'from':'Wien','to':'Bern','date':'2021-05-22T00:10:54.0224822+00:00','delayed':false},{'id':17,'from':'Wien','to':'Bern','date':'2021-05-22T01:10:54.0224822+00:00','delayed':false},{'id':18,'from':'Wien','to':'Frankfurt','date':'2021-05-22T02:10:54.0224822+00:00','delayed':false},{'id':19,'from':'Wien','to':'Frankfurt','date':'2021-05-22T03:10:54.0224822+00:00','delayed':false},{'id':20,'from':'Wien','to':'Frankfurt','date':'2021-05-22T04:10:54.0224822+00:00','delayed':false},{'id':21,'from':'Wien','to':'Salzburg','date':'2021-05-22T05:10:54.0224822+00:00','delayed':false},{'id':22,'from':'Wien','to':'Salzburg','date':'2021-05-22T06:10:54.0224822+00:00','delayed':false},{'id':23,'from':'Wien','to':'Salzburg','date':'2021-05-22T07:10:54.0224822+00:00','delayed':false},{'id':24,'from':'Wien','to':'Stuttgart','date':'2021-05-22T08:10:54.0224822+00:00','delayed':false},{'id':25,'from':'Wien','to':'Stuttgart','date':'2021-05-22T09:10:54.0224822+00:00','delayed':false},{'id':26,'from':'Wien','to':'Stuttgart','date':'2021-05-22T10:10:54.0224822+00:00','delayed':false},{'id':27,'from':'Berlin','to':'Wien','date':'2021-05-22T11:10:54.0224822+00:00','delayed':false},{'id':28,'from':'Berlin','to':'Wien','date':'2021-05-22T12:10:54.0224822+00:00','delayed':false},{'id':29,'from':'Berlin','to':'Wien','date':'2021-05-22T13:10:54.0224822+00:00','delayed':false},{'id':30,'from':'Berlin','to':'München','date':'2021-05-22T14:10:54.0224822+00:00','delayed':false},{'id':31,'from':'Berlin','to':'München','date':'2021-05-22T15:10:54.0224822+00:00','delayed':false},{'id':32,'from':'Berlin','to':'München','date':'2021-05-22T16:10:54.0224822+00:00','delayed':false},{'id':33,'from':'Berlin','to':'Zürich','date':'2021-05-22T17:10:54.0224822+00:00','delayed':false},{'id':34,'from':'Berlin','to':'Zürich','date':'2021-05-22T18:10:54.0224822+00:00','delayed':false},{'id':35,'from':'Berlin','to':'Zürich','date':'2021-05-22T19:10:54.0224822+00:00','delayed':false},{'id':36,'from':'Berlin','to':'Bern','date':'2021-05-22T20:10:54.0224822+00:00','delayed':false},{'id':37,'from':'Berlin','to':'Bern','date':'2021-05-22T21:10:54.0224822+00:00','delayed':false},{'id':38,'from':'Berlin','to':'Bern','date':'2021-05-22T22:10:54.0224822+00:00','delayed':false},{'id':39,'from':'Berlin','to':'Frankfurt','date':'2021-05-22T23:10:54.0224822+00:00','delayed':false},{'id':40,'from':'Berlin','to':'Frankfurt','date':'2021-05-23T00:10:54.0224822+00:00','delayed':false},{'id':41,'from':'Berlin','to':'Frankfurt','date':'2021-05-23T01:10:54.0224822+00:00','delayed':false},{'id':42,'from':'Berlin','to':'Salzburg','date':'2021-05-23T02:10:54.0224822+00:00','delayed':false},{'id':43,'from':'Berlin','to':'Salzburg','date':'2021-05-23T03:10:54.0224822+00:00','delayed':false},{'id':44,'from':'Berlin','to':'Salzburg','date':'2021-05-23T04:10:54.0224822+00:00','delayed':false},{'id':45,'from':'Berlin','to':'Stuttgart','date':'2021-05-23T05:10:54.0224822+00:00','delayed':false},{'id':46,'from':'Berlin','to':'Stuttgart','date':'2021-05-23T06:10:54.0224822+00:00','delayed':false},{'id':47,'from':'Berlin','to':'Stuttgart','date':'2021-05-23T07:10:54.0224822+00:00','delayed':false},{'id':48,'from':'München','to':'Wien','date':'2021-05-23T08:10:54.0224822+00:00','delayed':false},{'id':49,'from':'München','to':'Wien','date':'2021-05-23T09:10:54.0224822+00:00','delayed':false},{'id':50,'from':'München','to':'Wien','date':'2021-05-23T10:10:54.0224822+00:00','delayed':false},{'id':51,'from':'München','to':'Berlin','date':'2021-05-23T11:10:54.0224822+00:00','delayed':false},{'id':52,'from':'München','to':'Berlin','date':'2021-05-23T12:10:54.0224822+00:00','delayed':false},{'id':53,'from':'München','to':'Berlin','date':'2021-05-23T13:10:54.0224822+00:00','delayed':false},{'id':54,'from':'München','to':'Zürich','date':'2021-05-23T14:10:54.0224822+00:00','delayed':false},{'id':55,'from':'München','to':'Zürich','date':'2021-05-23T15:10:54.0224822+00:00','delayed':false},{'id':56,'from':'München','to':'Zürich','date':'2021-05-23T16:10:54.0224822+00:00','delayed':false},{'id':57,'from':'München','to':'Bern','date':'2021-05-23T17:10:54.0224822+00:00','delayed':false},{'id':58,'from':'München','to':'Bern','date':'2021-05-23T18:10:54.0224822+00:00','delayed':false},{'id':59,'from':'München','to':'Bern','date':'2021-05-23T19:10:54.0224822+00:00','delayed':false},{'id':60,'from':'München','to':'Frankfurt','date':'2021-05-23T20:10:54.0224822+00:00','delayed':false},{'id':61,'from':'München','to':'Frankfurt','date':'2021-05-23T21:10:54.0224822+00:00','delayed':false},{'id':62,'from':'München','to':'Frankfurt','date':'2021-05-23T22:10:54.0224822+00:00','delayed':false},{'id':63,'from':'München','to':'Salzburg','date':'2021-05-23T23:10:54.0224822+00:00','delayed':false},{'id':64,'from':'München','to':'Salzburg','date':'2021-05-24T00:10:54.0224822+00:00','delayed':false},{'id':65,'from':'München','to':'Salzburg','date':'2021-05-24T01:10:54.0224822+00:00','delayed':false},{'id':66,'from':'München','to':'Stuttgart','date':'2021-05-24T02:10:54.0224822+00:00','delayed':false},{'id':67,'from':'München','to':'Stuttgart','date':'2021-05-24T03:10:54.0224822+00:00','delayed':false},{'id':68,'from':'München','to':'Stuttgart','date':'2021-05-24T04:10:54.0224822+00:00','delayed':false},{'id':69,'from':'Zürich','to':'Wien','date':'2021-05-24T05:10:54.0224822+00:00','delayed':false},{'id':70,'from':'Zürich','to':'Wien','date':'2021-05-24T06:10:54.0224822+00:00','delayed':false},{'id':71,'from':'Zürich','to':'Wien','date':'2021-05-24T07:10:54.0224822+00:00','delayed':false},{'id':72,'from':'Zürich','to':'Berlin','date':'2021-05-24T08:10:54.0224822+00:00','delayed':false},{'id':73,'from':'Zürich','to':'Berlin','date':'2021-05-24T09:10:54.0224822+00:00','delayed':false},{'id':74,'from':'Zürich','to':'Berlin','date':'2021-05-24T10:10:54.0224822+00:00','delayed':false},{'id':75,'from':'Zürich','to':'München','date':'2021-05-24T11:10:54.0224822+00:00','delayed':false},{'id':76,'from':'Zürich','to':'München','date':'2021-05-24T12:10:54.0224822+00:00','delayed':false},{'id':77,'from':'Zürich','to':'München','date':'2021-05-24T13:10:54.0224822+00:00','delayed':false},{'id':78,'from':'Zürich','to':'Bern','date':'2021-05-24T14:10:54.0224822+00:00','delayed':false},{'id':79,'from':'Zürich','to':'Bern','date':'2021-05-24T15:10:54.0224822+00:00','delayed':false},{'id':80,'from':'Zürich','to':'Bern','date':'2021-05-24T16:10:54.0224822+00:00','delayed':false},{'id':81,'from':'Zürich','to':'Frankfurt','date':'2021-05-24T17:10:54.0224822+00:00','delayed':false},{'id':82,'from':'Zürich','to':'Frankfurt','date':'2021-05-24T18:10:54.0224822+00:00','delayed':false},{'id':83,'from':'Zürich','to':'Frankfurt','date':'2021-05-24T19:10:54.0224822+00:00','delayed':false},{'id':84,'from':'Zürich','to':'Salzburg','date':'2021-05-24T20:10:54.0224822+00:00','delayed':false},{'id':85,'from':'Zürich','to':'Salzburg','date':'2021-05-24T21:10:54.0224822+00:00','delayed':false},{'id':86,'from':'Zürich','to':'Salzburg','date':'2021-05-24T22:10:54.0224822+00:00','delayed':false},{'id':87,'from':'Zürich','to':'Stuttgart','date':'2021-05-24T23:10:54.0224822+00:00','delayed':false},{'id':88,'from':'Zürich','to':'Stuttgart','date':'2021-05-25T00:10:54.0224822+00:00','delayed':false},{'id':89,'from':'Zürich','to':'Stuttgart','date':'2021-05-25T01:10:54.0224822+00:00','delayed':false},{'id':90,'from':'Bern','to':'Wien','date':'2021-05-25T02:10:54.0224822+00:00','delayed':false},{'id':91,'from':'Bern','to':'Wien','date':'2021-05-25T03:10:54.0224822+00:00','delayed':false},{'id':92,'from':'Bern','to':'Wien','date':'2021-05-25T04:10:54.0224822+00:00','delayed':false},{'id':93,'from':'Bern','to':'Berlin','date':'2021-05-25T05:10:54.0224822+00:00','delayed':false},{'id':94,'from':'Bern','to':'Berlin','date':'2021-05-25T06:10:54.0224822+00:00','delayed':false},{'id':95,'from':'Bern','to':'Berlin','date':'2021-05-25T07:10:54.0224822+00:00','delayed':false},{'id':96,'from':'Bern','to':'München','date':'2021-05-25T08:10:54.0224822+00:00','delayed':false},{'id':97,'from':'Bern','to':'München','date':'2021-05-25T09:10:54.0224822+00:00','delayed':false},{'id':98,'from':'Bern','to':'München','date':'2021-05-25T10:10:54.0224822+00:00','delayed':false},{'id':99,'from':'Bern','to':'Zürich','date':'2021-05-25T11:10:54.0224822+00:00','delayed':false},{'id':100,'from':'Bern','to':'Zürich','date':'2021-05-25T12:10:54.0224822+00:00','delayed':false},{'id':101,'from':'Bern','to':'Zürich','date':'2021-05-25T13:10:54.0224822+00:00','delayed':false},{'id':102,'from':'Bern','to':'Frankfurt','date':'2021-05-25T14:10:54.0224822+00:00','delayed':false},{'id':103,'from':'Bern','to':'Frankfurt','date':'2021-05-25T15:10:54.0224822+00:00','delayed':false},{'id':104,'from':'Bern','to':'Frankfurt','date':'2021-05-25T16:10:54.0224822+00:00','delayed':false},{'id':105,'from':'Bern','to':'Salzburg','date':'2021-05-25T17:10:54.0224822+00:00','delayed':false},{'id':106,'from':'Bern','to':'Salzburg','date':'2021-05-25T18:10:54.0224822+00:00','delayed':false},{'id':107,'from':'Bern','to':'Salzburg','date':'2021-05-25T19:10:54.0224822+00:00','delayed':false},{'id':108,'from':'Bern','to':'Stuttgart','date':'2021-05-25T20:10:54.0224822+00:00','delayed':false},{'id':109,'from':'Bern','to':'Stuttgart','date':'2021-05-25T21:10:54.0224822+00:00','delayed':false},{'id':110,'from':'Bern','to':'Stuttgart','date':'2021-05-25T22:10:54.0224822+00:00','delayed':false},{'id':111,'from':'Frankfurt','to':'Wien','date':'2021-05-25T23:10:54.0224822+00:00','delayed':false},{'id':112,'from':'Frankfurt','to':'Wien','date':'2021-05-26T00:10:54.0224822+00:00','delayed':false},{'id':113,'from':'Frankfurt','to':'Wien','date':'2021-05-26T01:10:54.0224822+00:00','delayed':false},{'id':114,'from':'Frankfurt','to':'Berlin','date':'2021-05-26T02:10:54.0224822+00:00','delayed':false},{'id':115,'from':'Frankfurt','to':'Berlin','date':'2021-05-26T03:10:54.0224822+00:00','delayed':false},{'id':116,'from':'Frankfurt','to':'Berlin','date':'2021-05-26T04:10:54.0224822+00:00','delayed':false},{'id':117,'from':'Frankfurt','to':'München','date':'2021-05-26T05:10:54.0224822+00:00','delayed':false},{'id':118,'from':'Frankfurt','to':'München','date':'2021-05-26T06:10:54.0224822+00:00','delayed':false},{'id':119,'from':'Frankfurt','to':'München','date':'2021-05-26T07:10:54.0224822+00:00','delayed':false},{'id':120,'from':'Frankfurt','to':'Zürich','date':'2021-05-26T08:10:54.0224822+00:00','delayed':false},{'id':121,'from':'Frankfurt','to':'Zürich','date':'2021-05-26T09:10:54.0224822+00:00','delayed':false},{'id':122,'from':'Frankfurt','to':'Zürich','date':'2021-05-26T10:10:54.0224822+00:00','delayed':false},{'id':123,'from':'Frankfurt','to':'Bern','date':'2021-05-26T11:10:54.0224822+00:00','delayed':false},{'id':124,'from':'Frankfurt','to':'Bern','date':'2021-05-26T12:10:54.0224822+00:00','delayed':false},{'id':125,'from':'Frankfurt','to':'Bern','date':'2021-05-26T13:10:54.0224822+00:00','delayed':false},{'id':126,'from':'Frankfurt','to':'Salzburg','date':'2021-05-26T14:10:54.0224822+00:00','delayed':false},{'id':127,'from':'Frankfurt','to':'Salzburg','date':'2021-05-26T15:10:54.0224822+00:00','delayed':false},{'id':128,'from':'Frankfurt','to':'Salzburg','date':'2021-05-26T16:10:54.0224822+00:00','delayed':false},{'id':129,'from':'Frankfurt','to':'Stuttgart','date':'2021-05-26T17:10:54.0224822+00:00','delayed':false},{'id':130,'from':'Frankfurt','to':'Stuttgart','date':'2021-05-26T18:10:54.0224822+00:00','delayed':false},{'id':131,'from':'Frankfurt','to':'Stuttgart','date':'2021-05-26T19:10:54.0224822+00:00','delayed':false},{'id':132,'from':'Salzburg','to':'Wien','date':'2021-05-26T20:10:54.0224822+00:00','delayed':false},{'id':133,'from':'Salzburg','to':'Wien','date':'2021-05-26T21:10:54.0224822+00:00','delayed':false},{'id':134,'from':'Salzburg','to':'Wien','date':'2021-05-26T22:10:54.0224822+00:00','delayed':false},{'id':135,'from':'Salzburg','to':'Berlin','date':'2021-05-26T23:10:54.0224822+00:00','delayed':false},{'id':136,'from':'Salzburg','to':'Berlin','date':'2021-05-27T00:10:54.0224822+00:00','delayed':false},{'id':137,'from':'Salzburg','to':'Berlin','date':'2021-05-27T01:10:54.0224822+00:00','delayed':false},{'id':138,'from':'Salzburg','to':'München','date':'2021-05-27T02:10:54.0224822+00:00','delayed':false},{'id':139,'from':'Salzburg','to':'München','date':'2021-05-27T03:10:54.0224822+00:00','delayed':false},{'id':140,'from':'Salzburg','to':'München','date':'2021-05-27T04:10:54.0224822+00:00','delayed':false},{'id':141,'from':'Salzburg','to':'Zürich','date':'2021-05-27T05:10:54.0224822+00:00','delayed':false},{'id':142,'from':'Salzburg','to':'Zürich','date':'2021-05-27T06:10:54.0224822+00:00','delayed':false},{'id':143,'from':'Salzburg','to':'Zürich','date':'2021-05-27T07:10:54.0224822+00:00','delayed':false},{'id':144,'from':'Salzburg','to':'Bern','date':'2021-05-27T08:10:54.0224822+00:00','delayed':false},{'id':145,'from':'Salzburg','to':'Bern','date':'2021-05-27T09:10:54.0224822+00:00','delayed':false},{'id':146,'from':'Salzburg','to':'Bern','date':'2021-05-27T10:10:54.0224822+00:00','delayed':false},{'id':147,'from':'Salzburg','to':'Frankfurt','date':'2021-05-27T11:10:54.0224822+00:00','delayed':false},{'id':148,'from':'Salzburg','to':'Frankfurt','date':'2021-05-27T12:10:54.0224822+00:00','delayed':false},{'id':149,'from':'Salzburg','to':'Frankfurt','date':'2021-05-27T13:10:54.0224822+00:00','delayed':false},{'id':150,'from':'Salzburg','to':'Stuttgart','date':'2021-05-27T14:10:54.0224822+00:00','delayed':false},{'id':151,'from':'Salzburg','to':'Stuttgart','date':'2021-05-27T15:10:54.0224822+00:00','delayed':false},{'id':152,'from':'Salzburg','to':'Stuttgart','date':'2021-05-27T16:10:54.0224822+00:00','delayed':false},{'id':153,'from':'Stuttgart','to':'Wien','date':'2021-05-27T17:10:54.0224822+00:00','delayed':false},{'id':154,'from':'Stuttgart','to':'Wien','date':'2021-05-27T18:10:54.0224822+00:00','delayed':false},{'id':155,'from':'Stuttgart','to':'Wien','date':'2021-05-27T19:10:54.0224822+00:00','delayed':false},{'id':156,'from':'Stuttgart','to':'Berlin','date':'2021-05-27T20:10:54.0224822+00:00','delayed':false},{'id':157,'from':'Stuttgart','to':'Berlin','date':'2021-05-27T21:10:54.0224822+00:00','delayed':false},{'id':158,'from':'Stuttgart','to':'Berlin','date':'2021-05-27T22:10:54.0224822+00:00','delayed':false},{'id':159,'from':'Stuttgart','to':'München','date':'2021-05-27T23:10:54.0224822+00:00','delayed':false},{'id':160,'from':'Stuttgart','to':'München','date':'2021-05-28T00:10:54.0224822+00:00','delayed':false},{'id':161,'from':'Stuttgart','to':'München','date':'2021-05-28T01:10:54.0224822+00:00','delayed':false},{'id':162,'from':'Stuttgart','to':'Zürich','date':'2021-05-28T02:10:54.0224822+00:00','delayed':false},{'id':163,'from':'Stuttgart','to':'Zürich','date':'2021-05-28T03:10:54.0224822+00:00','delayed':false},{'id':164,'from':'Stuttgart','to':'Zürich','date':'2021-05-28T04:10:54.0224822+00:00','delayed':false},{'id':165,'from':'Stuttgart','to':'Bern','date':'2021-05-28T05:10:54.0224822+00:00','delayed':false},{'id':166,'from':'Stuttgart','to':'Bern','date':'2021-05-28T06:10:54.0224822+00:00','delayed':false},{'id':167,'from':'Stuttgart','to':'Bern','date':'2021-05-28T07:10:54.0224822+00:00','delayed':false},{'id':168,'from':'Stuttgart','to':'Frankfurt','date':'2021-05-28T08:10:54.0224822+00:00','delayed':false},{'id':169,'from':'Stuttgart','to':'Frankfurt','date':'2021-05-28T09:10:54.0224822+00:00','delayed':false},{'id':170,'from':'Stuttgart','to':'Frankfurt','date':'2021-05-28T10:10:54.0224822+00:00','delayed':false},{'id':171,'from':'Stuttgart','to':'Salzburg','date':'2021-05-28T11:10:54.0224822+00:00','delayed':false},{'id':172,'from':'Stuttgart','to':'Salzburg','date':'2021-05-28T12:10:54.0224822+00:00','delayed':false},{'id':173,'from':'Stuttgart','to':'Salzburg','date':'2021-05-28T13:10:54.0224822+00:00','delayed':false},{'id':174,'from':'Linz','to':'Graz','date':'2021-05-26T00:00:00','delayed':false},{'id':175,'from':'Linz','to':'Graz','date':'2021-05-25T00:00:00','delayed':false},{'id':176,'from':'Frankenburg','to':'Salzburg','date':'2021-05-25T00:00:00','delayed':false}]";


  private static List<Flight> flights;
  public static List<Flight> Flights
  {
    get {
          if (flights==null) {
            flights = JsonConvert.DeserializeObject<List<Flight>>(JSON);
          }
          return flights;
       }
  }
}