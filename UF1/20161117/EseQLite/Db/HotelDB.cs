﻿using EseQLite.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EseQLite.Db
{
    class HotelDB
    {




        public static void updateData(int pCodi, string pNom, string pPoblacio)
        {             
            using (HotelContext ctx = new HotelContext())
            {

                using (var connection = ctx.Database.GetDbConnection())
                {
                    connection.Open();
                    DbTransaction trans = connection.BeginTransaction();
                    using (var command = connection.CreateCommand())
                    {
                        try
                        {
                            command.CommandText = $"update hotel set htl_nom='{pNom}', htl_poblacio='{pPoblacio}' where htl_codi={pCodi}";
                            command.Transaction = trans;
                            int filesUpdatades = command.ExecuteNonQuery();
                            if (filesUpdatades != 1)
                            {
                                throw new Exception("Error !");
                            }
                            trans.Commit();

                        }catch(Exception ex)
                        {
                            trans.Rollback();
                            throw new Exception("Error !");
                        }
                         
                    }
                }
            }

        }




        public static List<Hotel> getHotels()
        {
            List<Hotel> hotels = new List<Hotel>();

            using (HotelContext ctx = new HotelContext())
            {

                using (var connection = ctx.Database.GetDbConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "select * from hotel";
                        DbDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Int64 id = reader.GetInt64(reader.GetOrdinal("htl_codi"));
                            string nom = reader.GetString(reader.GetOrdinal("htl_nom"));                            
                            string poblacio = reader.GetString(reader.GetOrdinal("htl_poblacio"));
                            Hotel h = new Hotel(id, nom, poblacio);
                            hotels.Add(h);                            
                        }
                    }
                }
            }
            return hotels;
        }


        public Int64 getNumeroHotels()
        {

            using (HotelContext ctx = new HotelContext())
            {
                //Get student name of string type
                using (var connection = ctx.Database.GetDbConnection())
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "select count(*) from hotel";
                        var count = command.ExecuteScalar();
                        return (Int64)count;
                    }
                }
            }
            return 0;
        }
    }
}