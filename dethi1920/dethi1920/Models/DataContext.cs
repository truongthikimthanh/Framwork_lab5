using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace dethi1920.Models
{
    public class DataContext
    {
        public string ConnectionString { get; set; } // Biến thành viên

        public DataContext(string connectionstring)
        {
            this.ConnectionString = connectionstring;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public int Create(DiemCachLyModel ch)
        {
            int count = 0;
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var query = "insert into diemcachly values(@maDiemCachLy, @tenDiemCachLy, @diaChi)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("maDiemCachLy", ch.MaDiemCachLy);
                cmd.Parameters.AddWithValue("tenDiemCachLy", ch.TenDiemCachLy);
                cmd.Parameters.AddWithValue("diaChi", ch.DiaChi);
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public List<object> getCongNhan(int soLan)
        {
            List<object> list = new List<object>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var query = @"select n.macongnhan, n.tencongnhan, n.namsinh, n.nuocve, count(*) as SoLan
                               from congnhan n join cntc c on n.macongnhan=c.macongnhan
                                group by n.macongnhan,  n.tencongnhan, n.namsinh, n.nuocve
                               having count(*) >= @solaninput";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@solaninput", soLan);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            MaCongNhan = reader["macongnhan"].ToString(),
                            TenCongNhan = reader["tencongnhan"].ToString(),
                            SoLan = Convert.ToInt32(reader["soLan"].ToString()),
                            NamSinh = Convert.ToInt32(reader["namsinh"].ToString()),
                            NuocVe = reader["nuocve"].ToString(),
                        });

                    }
                }
            }
            return list;
        }

        // Liet ke ten nhan vien
        public List<DiemCachLyModel> getDiemCachLy()
        {
            List<DiemCachLyModel> list = new List<DiemCachLyModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var query = "select madiemcachly, tendiemcachly from diemcachly";
                SqlCommand cmd = new SqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DiemCachLyModel()
                        {
                            MaDiemCachLy = reader["madiemcachly"].ToString(),
                            TenDiemCachLy= reader["tendiemcachly"].ToString(),
                            
                        });

                    }
                }
            }
            return list;
        }
        
        public List<CongNhanModel> getCNCL(string madiemcachly)
        {
            List<CongNhanModel > n = new List<CongNhanModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var query = "select macongnhan, tencongnhan, madiemcachly from congnhan where madiemcachly=@madiemcachly";
                SqlCommand cmd = new SqlCommand(query, conn);
                
                cmd.Parameters.AddWithValue("@madiemcachly", madiemcachly);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       n.Add(new CongNhanModel()
                        { 
                        MaCongNhan = reader["macongnhan"].ToString(),
                        TenCongNhan = reader["tencongnhan"].ToString()
                            });
                        

                    }
                }
            }
            return n;
        }
        
        public List<CongNhanModel> getCN(string madiemcachly)
        {
            List<CongNhanModel> n = new List<CongNhanModel>();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var query = "select macongnhan, tencongnhan, gioitinh, namsinh, nuocve from congnhan where madiemcachly=@madiemcachly";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@madiemcachly", madiemcachly);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        n.Add(new CongNhanModel()
                        {
                            MaCongNhan = reader["macongnhan"].ToString(),
                            TenCongNhan = reader["tencongnhan"].ToString(),
                            GioiTinh = Convert.ToInt32(reader["gioitinh"].ToString()),
                            NamSinh = Convert.ToInt32(reader["namsinh"].ToString()),
                            NuocVe = reader["nuocve"].ToString(),

                        });


                    }
                }
            }
            return n;
        }
        public int DeleteCN(string MaCongNhan, CongNhanModel c)
        {
            int count = 0;
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var query = "delete from congnhan where macongnhan = @macongnhan";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@macongnhan", c.MaCongNhan); 
              
              
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }
        public int DetailCN(CongNhanModel n, string macongnhan)
        {
            int count = 0;
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                var query = "select* from congnhan where macongnhan = @macongnhan ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@macongnhan", n.MaCongNhan);
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

    }
}
