﻿using System.Text;
//using Newtonsoft.Json;
using System.IO;
using System.Data.Entity;
using System.Net;
using System;
using System.Collections.Generic;
using data_mos_ru;
using data_mos_ru.Entityes;

namespace ConsoleApplication1

{
    class Program
    {

        static void Main(string[] args)
        {
            data_mos_ru_Operator dmrOper = new data_mos_ru_Operator("integra");;
            DirectoryInfo wdir = new DirectoryInfo("C:\\Users\\Bushmakin\\Documents\\Новая папка\\data_mos_ru");
            FileInfo[] d6427 = wdir.GetFiles("data-6427*.json");
            FileInfo[] d6430 = wdir.GetFiles("data-6430*.json");
            FileInfo[] d6431 = wdir.GetFiles("data-6431*.json");
            FileInfo[] d6433 = wdir.GetFiles("data-6433*.json");
            FileInfo[] d6435 = wdir.GetFiles("data-6435*.json");
            FileInfo[] d6438 = wdir.GetFiles("data-6438*.json");
            FileInfo[] d6436 = wdir.GetFiles("data-6436*.json");
            FileInfo[] d6432 = wdir.GetFiles("data-6432*.json");
            FileInfo[] d29580 = wdir.GetFiles("data-29580*.json");
            FileInfo[] d2624_8684 = wdir.GetFiles("data-8684*.json");
            FileInfo[] d1641_5988 = wdir.GetFiles("data-5988*.json");
            FileInfo[] d54518 = wdir.GetFiles("data-54518*.json");
            FileInfo[] dUPR = wdir.GetFiles("UPR.json");
            //FileInfo[] d6427 = wdir.GetFiles("data-6427*.json")[0];

            //dmrOper.DeserializeUM_type(d6430[0].FullName, Encoding.GetEncoding(1251));
            //dmrOper.DeserializeUM(d6427[0].FullName, Encoding.GetEncoding(1251));

            //dmrOper.DeserializeTM_Type(d6433[0].FullName, Encoding.GetEncoding(1251));
            //dmrOper.DeserializeTM(d6431[0].FullName, Encoding.GetEncoding(1251));

            //dmrOper.DeserializeMO_Type(d6438[0].FullName, Encoding.GetEncoding(1251));
            //dmrOper.DeserializeMO(d6435[0].FullName,Encoding.GetEncoding(1251));

            //dmrOper.Update(dmrOper.Convert<AO_60562>(d29580[0].FullName,Encoding.GetEncoding(1251)));
            //dmrOper.Update(dmrOper.Convert<data_2624_8684>(d2624_8684[0].FullName,Encoding.GetEncoding(1251)));
            //dmrOper.Update(dmrOper.Convert<Data_1641_5988>(d1641_5988[0].FullName, Encoding.GetEncoding(1251)));
            //dmrOper.Update(dmrOper.Convert<data_54518>(d54518[0].FullName, Encoding.GetEncoding(1251)));
            //dmrOper.Update(dmrOper.Convert<UPR>(dUPR[0].FullName, Encoding.UTF8));
            //dmrOper.LoadDom();
            dmrOper.UpdateHouses();
            //dmrOper.DeserializeOMK002_2013_1("D:\\data_mos_ru\\data-6434-2017-12-24\\data-6434-2017-12-24.json", Encoding.GetEncoding(1251));
            //dmrOper.DeserializeOMK002_2013_2(d6436[0].FullName, Encoding.GetEncoding(1251));


            //dmrOper.DeserializeAO(new DirectoryInfo("D:\\data_mos_ru\\data-4277-2017-11-23").GetFiles("*.json"), Encoding.GetEncoding(1251));
            //dmrOper.DeserializeAO(new FileInfo("D:\\data.mos.ru\\data-4277-2016-12-21-2.json"), Encoding.UTF8);
            //dmrOper.DeserializeAO(new FileInfo("D:\\data.mos.ru\\data-4277-2016-12-21-3.json"), Encoding.UTF8);
            //dmrOper.DeserializeAO(new FileInfo("D:\\data.mos.ru\\data-4277-2016-12-21-4.json"), Encoding.UTF8);

            //dmrOper.DeserializeTMED(d6432[0].FullName, Encoding.GetEncoding(1251));

            //dmrOper.DeserializeAO(Encoding.UTF8);
            //dmrOper.LoadGeoJSON_AO(File.OpenRead("D:\\Filetable1\\ao.geojson"), Encoding.UTF8);

            //dmrOper.LoadGeoJSON_MO(File.OpenRead("D:\\Filetable1\\mo.geojson"), Encoding.UTF8);

        }
    }
}
