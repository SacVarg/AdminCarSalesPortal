using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Car_Sales_Portal
{
    public class dml:connection
    {
        public void companydetails(string id,string name,string address,string mob,string land,string email,string webaddr)
        {
            SqlCommand cmd = new SqlCommand("insert into COMPANY_DETAILS values(@id,@name,@addr,@mob,@land,@email,@webaadr)", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@addr", address);
            cmd.Parameters.AddWithValue("@mob", mob);
            cmd.Parameters.AddWithValue("@land", land);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@webaadr", webaddr);
            cmd.ExecuteNonQuery();

        }
        public string inc()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(COMPANY_ID)+1,1) from COMPANY_DETAILS", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public void typedetails(string id,string name)
        {
            SqlCommand cmd = new SqlCommand("insert into TYPE_DETAILS values(@id,@name)", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
        }
        public string inc1()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(TYPE_ID)+1,1) from TYPE_DETAILS", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public void modeldetails(string id,string name,string fileName,string status,string video)
        {
            SqlCommand cmd = new SqlCommand("insert into MODEL_TABLE values(@id,@name,@fileName,@status,@video)", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@fileName", fileName);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@video", video);
            cmd.ExecuteNonQuery();
        }
        public string inc2()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(MODEL_ID)+1,1) from MODEL_TABLE", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public void featuredetails(string id,string name)
        {
            SqlCommand cmd = new SqlCommand("insert into FEATURE_DETAILS values(@id,@name)", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
        }
        public string inc3()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(FEATURE_ID)+1,1) from FEATURE_DETAILS", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public DataTable getmodeldetails(string s)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from MODEL_TABLE", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                if(s=="0")
                {
                    dt.Rows.InsertAt(dt.NewRow(), 0);
                    dt.Rows[0]["MODEL_NAME"] = "<---Select---->";
                    dt.Rows[0]["MODEL_ID"] = "0";
                }
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }


        public DataTable getcompdetails()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from COMPANY_DETAILS", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }
        public DataTable gettypedetails( string s)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from TYPE_DETAILS", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                if (s == "0")
                {
                    dt.Rows.InsertAt(dt.NewRow(), 0);
                    dt.Rows[0]["TYPE_NAME"] = "<---Select---->";
                    dt.Rows[0]["TYPE_ID"] = "0";
                }
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }

        public void subdetails(string id, string name, string modelid, string typeid, string fileName,string adamount)
        {
            SqlCommand cmd = new SqlCommand("insert into SUBMODEL_DETAILS values(@id,@name,@mid,@tid,@fil,@adamount)", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@mid", modelid);
            cmd.Parameters.AddWithValue("@tid",typeid);
            cmd.Parameters.AddWithValue("@fil", fileName);
            cmd.Parameters.AddWithValue("@adamount", adamount);
            cmd.ExecuteNonQuery();
        }
        public string inc4()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(SUBMODEL_ID)+1,1) from SUBMODEL_DETAILS", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public DataTable getsmodeldetails(string s)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from SUBMODEL_DETAILS", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                if(s=="0")
                {
                    dt.Rows.InsertAt(dt.NewRow(), 0);
                    dt.Rows[0]["SUBMODEL_NAME"] = "<---Select---->";
                    dt.Rows[0]["SUBMODEL_ID"] = "0";
                }
                
                
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable getfeaturedetails(string s)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from FEATURE_DETAILS", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public void smdetails(string id,string id1,string id2,string id3)
        {
            SqlCommand cmd = new SqlCommand("insert into SMFEATURE_DETAILS values(@id,@id1,@id2,@id3)", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@id1", id1);
            cmd.Parameters.AddWithValue("@id2", id2);
            cmd.Parameters.AddWithValue("@id3", id3);
            cmd.ExecuteNonQuery();

        }




        internal DataTable getcompdetails(string cmpid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from COMPANY_DETAILS where COMPANY_ID=@id", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@id", cmpid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }

        public void update_company_details(string id,string name,string address,string mobno,string landno,string email,string webaddr)
        {
            SqlCommand cmd = new SqlCommand("update COMPANY_DETAILS set COMPANY_ID=@id,COMPANY_NAME=@name,ADDRESS=@addr,MOBILE_CONTACT_NO=@mobno,LAND_CONTACT_NO=@landno,E_MAIL=@email,WEB_ADDRESS=@webaddr where COMPANY_ID=@id", sqlcon);
            
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@addr",address);
            cmd.Parameters.AddWithValue("@mobno", mobno);
            cmd.Parameters.AddWithValue("@landno", landno);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@webaddr", webaddr);
            cmd.ExecuteNonQuery();
        }



        internal DataTable gettypedetails_rep(string typeid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from TYPE_DETAILS where TYPE_ID=@id", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@id", typeid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public void update_type_details(string id,string name)
        {
            SqlCommand cmd = new SqlCommand("update TYPE_DETAILS set TYPE_ID=@id,TYPE_NAME=@name where TYPE_ID=@id", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
        }


        internal DataTable getmodeldetails_rep(string modelid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from MODEL_TABLE where MODEL_ID=@id", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@id", modelid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public void update_model_details(string id,string name,string fileName,string status,string video)
        {
            if(fileName!="")
            {
                SqlCommand cmd = new SqlCommand("update MODEL_TABLE set MODEL_NAME=@name,MODEL_PICTURE=@fileName,STATUS=@status,VIDEO_LINK=@video where MODEL_ID=@id", sqlcon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@fileName", fileName);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@video", video);
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update MODEL_TABLE set MODEL_ID=@id,MODEL_NAME=@name,STATUS=@status,VIDEO_LINK=@video where MODEL_ID=@id", sqlcon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@video", video);
                cmd.ExecuteNonQuery();
            }

        }

        internal DataTable getfeaturedetails_rep(string featureid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from FEATURE_DETAILS where FEATURE_ID=@id", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@id", featureid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public void update_feature_details(string id,string name)
        {
            SqlCommand cmd = new SqlCommand("update FEATURE_DETAILS set FEATURE_ID=@id,FEATURE_NAME=@name where FEATURE_ID=@id", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
        }

        internal DataTable getsubmodeldetails_rep(string submodelid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from SUBMODEL_DETAILS where SUBMODEL_ID=@id", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@id", submodelid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public void update_submodel_details(string id,string name,string mid,string tid,string pic,string amount)
        {
            SqlCommand cmd = new SqlCommand();
            if(pic=="")
            {
                cmd = new SqlCommand("update SUBMODEL_DETAILS set SUBMODEL_ID=@id,SUBMODEL_NAME=@name,MODEL_ID=@mid,TYPE_ID=@tid,ADV_AMOUNT=@amount where SUBMODEL_ID=@id", sqlcon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@mid", mid);
                cmd.Parameters.AddWithValue("@tid", tid);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.ExecuteNonQuery();
            }
            else if(pic!="")
            {
                cmd = new SqlCommand("update SUBMODEL_DETAILS set SUBMODEL_ID=@id,SUBMODEL_NAME=@name,MODEL_ID=@mid,TYPE_ID=@tid,PICTURE=@pic,ADV_AMOUNT=@amount where SUBMODEL_ID=@id", sqlcon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@mid", mid);
                cmd.Parameters.AddWithValue("@tid", tid);
                cmd.Parameters.AddWithValue("@pic", pic);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.ExecuteNonQuery();
            }
            
        }
        public DataTable getsmfeaturedetails()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT distinct MODEL_TABLE.MODEL_NAME, SUBMODEL_DETAILS.SUBMODEL_NAME, SMFEATURE_DETAILS.SMF_ID FROM MODEL_TABLE INNER JOIN SUBMODEL_DETAILS ON MODEL_TABLE.MODEL_ID = SUBMODEL_DETAILS.MODEL_ID INNER JOIN SMFEATURE_DETAILS ON SUBMODEL_DETAILS.SUBMODEL_ID = SMFEATURE_DETAILS.SUBMODEL_ID", sqlcon);
                //Adpt = new SqlDataAdapter("SELECT FEATURE_DETAILS.FEATURE_NAME, SUBMODEL_DETAILS.SUBMODEL_NAME, SUBMODEL_DETAILS.SUBMODEL_ID, FEATURE_DETAILS.FEATURE_ID, SMFEATURE_DETAILS.SMF_ID FROM FEATURE_DETAILS INNER JOIN SMFEATURE_DETAILS ON FEATURE_DETAILS.FEATURE_ID = SMFEATURE_DETAILS.FEATURE_ID INNER JOIN SUBMODEL_DETAILS ON SMFEATURE_DETAILS.SUBMODEL_ID = SUBMODEL_DETAILS.SUBMODEL_ID", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }

        internal DataTable get_sm_feature_details(string smf_id)
        {
            try
            {
                    SqlDataAdapter Adpt = new SqlDataAdapter();
                    Adpt = new SqlDataAdapter("select * from SMFEATURE_DETAILS where SMF_ID=@id1", sqlcon);
                    Adpt.SelectCommand.Parameters.AddWithValue("@id1", smf_id);
                    DataTable dt = new DataTable();
                    Adpt.Fill(dt);
                    return dt; 
                
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public void update_smfeature_details(string id1)
        {
            SqlCommand cmd = new SqlCommand("delete from SMFEATURE_DETAILS where SUBMODEL_ID=@id1", sqlcon);
            cmd.Parameters.AddWithValue("@id1", id1);
            cmd.ExecuteNonQuery();
        }

        public string inc5()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(SMF_ID)+1,1) from SMFEATURE_DETAILS", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public string inc6()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(COLOR_ID)+1,1)from COLOR_DETAILS", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public void colordetails(string id,string name)
        {
            SqlCommand cmd = new SqlCommand("insert into COLOR_DETAILS values(@id,@name)", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
        }

        public DataTable getcolordetails(string s)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from COLOR_DETAILS", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                if (s == "0")
                {
                    dt.Rows.InsertAt(dt.NewRow(), 0);
                    dt.Rows[0]["COLOR_NAME"] = "<---Select---->";
                    dt.Rows[0]["COLOR_ID"] = "0";
                }
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public string inc7()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(PRICE_ID)+1,1)from PRICE_DETAILS", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public DataTable getsubmodel_drop(string s)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select SUBMODEL_ID,SUBMODEL_NAME from SUBMODEL_DETAILS where MODEL_ID=@s", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@s", s);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                dt.Rows.InsertAt(dt.NewRow(), 0);
                dt.Rows[0]["SUBMODEL_NAME"] = "<---Select---->";
                dt.Rows[0]["SUBMODEL_ID"] = "0";
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
           
        }
        public void pricedetails(string id,string mid,string smid,string cid,string price,string days)
        {
            SqlCommand cmd = new SqlCommand("insert into PRICE_DETAILS values(@id,@mid,@smid,@cid,@price,@days)", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@smid", smid);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@days", days);
            cmd.ExecuteNonQuery();
        }
        public int check1(string s1,string s2,string s3)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from PRICE_DETAILS where MODEL_ID=@s1 and SUBMODEL_ID=@s2 and COLOR_ID=@s3", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@s1", s1);
                Adpt.SelectCommand.Parameters.AddWithValue("@s2", s2);
                Adpt.SelectCommand.Parameters.AddWithValue("@s3", s3);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt.Rows.Count;
            }
             catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return -1;
                throw ex;
            }
            
        }

        public DataTable getpricedetails()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from PRICE_DETAILS", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }

        internal DataTable getpricedetails_edit(string priceid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from PRICE_DETAILS where PRICE_ID=@id1", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@id1", priceid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }

        public void update_pricedetails(string id,string mid,string sid,string cid,string price,string exp)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("update PRICE_DETAILS set MODEL_ID=@mid,SUBMODEL_ID=@sid,COLOR_ID=@cid,PRICE=@price,EXPECTED_DAYS=@e where PRICE_ID=@id", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@mid",mid);
            cmd.Parameters.AddWithValue("@sid",sid);
            cmd.Parameters.AddWithValue("@cid",cid);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@e", exp);
            cmd.ExecuteNonQuery();
        }

        public int check2(string s1, string s2)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from SMFEATURE_DETAILS where MODEL_ID=@s1 and SUBMODEL_ID=@s2", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@s1", s1);
                Adpt.SelectCommand.Parameters.AddWithValue("@s2", s2);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt.Rows.Count;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return -1;
                throw ex;
            }

        }
        public DataTable get_print(string booking_date)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT BOOKING_DETAILS.BOOKING_ID, MODEL_TABLE.MODEL_NAME, TYPE_DETAILS.TYPE_NAME, SUBMODEL_DETAILS.SUBMODEL_NAME, BOOKING_DETAILS.AMOUNT, COLOR_DETAILS.COLOR_NAME, USER_DETAILS.FIRST_NAME, USER_DETAILS.USER_NAME, BOOKING_DETAILS.BOOKING_DATE FROM BOOKING_DETAILS INNER JOIN COLOR_DETAILS ON BOOKING_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID INNER JOIN TYPE_DETAILS INNER JOIN SUBMODEL_DETAILS ON TYPE_DETAILS.TYPE_ID = SUBMODEL_DETAILS.TYPE_ID INNER JOIN MODEL_TABLE ON SUBMODEL_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID ON BOOKING_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID AND BOOKING_DETAILS.SUBMODEL_ID = SUBMODEL_DETAILS.SUBMODEL_ID INNER JOIN USER_DETAILS ON BOOKING_DETAILS.USER_ID = USER_DETAILS.USER_ID WHERE(BOOKING_DETAILS.BOOKING_DATE = CONVERT(DATETIME,@date, 102)) AND (BOOKING_DETAILS.STATUS='B') ", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@date", booking_date);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }
        public string inc8()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(ADMIN_ID)+1,1)from ADMIN_DETAILS", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public void admin_details(string id,string name,string password,string email)
        {
            SqlCommand cmd = new SqlCommand("insert into ADMIN_DETAILS values(@id,@name,@password,@email)", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
        }
        public DataTable check3(string name,string password)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from ADMIN_DETAILS where ADMIN_NAME=@name AND PASSWORD=@password", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@name", name);
                Adpt.SelectCommand.Parameters.AddWithValue("@password", password);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }

        public DataTable get_admin(string id)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from ADMIN_DETAILS where ADMIN_NAME=@id", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }
        public void change_password(string id,string password)
        {
            SqlCommand cmd = new SqlCommand("update ADMIN_DETAILS set PASSWORD=@password where ADMIN_NAME=@id", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
        }
        public DataTable get_rept_sliderimages()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from SLIDER_IMAGE", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }

        public DataTable get_sliderimages(string id)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from SLIDER_IMAGE where PIC_ID=@id", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }

        }
        public void update_slider(string id, string pic1, string pic2, string pic3, string pic4)
        {
            SqlCommand cmd = new SqlCommand("UPDATE SLIDER_IMAGE SET PICTURE1=@pic1,PICTURE2=@pic2,PICTURE3=@pic3,PICTURE4=@pic4 WHERE PIC_ID=@id ", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pic1", pic1);
            cmd.Parameters.AddWithValue("@pic2", pic2);
            cmd.Parameters.AddWithValue("@pic3", pic3);
            cmd.Parameters.AddWithValue("@pic4", pic4);
            cmd.ExecuteNonQuery();
        }
        public string inc9()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(METHOD_ID)+1,1)from PAYMENT_MASTER", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }
        public DataTable getPayment_Details()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("select * from PAYMENT_MASTER", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public void payment_details(string id,string name)
        {
            SqlCommand cmd = new SqlCommand("insert into PAYMENT_MASTER values(@id,@name)", sqlcon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
        }
        public DataTable getIssue_Details()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT BOOKING_DETAILS.BOOKING_ID, SUBMODEL_DETAILS.SUBMODEL_NAME, MODEL_TABLE.MODEL_NAME, USER_DETAILS.FIRST_NAME, USER_DETAILS.LAST_NAME, BOOKING_DETAILS.STATUS, BOOKING_DETAILS.BALANCE_AMOUNT FROM BOOKING_DETAILS INNER JOIN USER_DETAILS ON BOOKING_DETAILS.USER_ID = USER_DETAILS.USER_ID INNER JOIN MODEL_TABLE ON BOOKING_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID INNER JOIN SUBMODEL_DETAILS ON BOOKING_DETAILS.SUBMODEL_ID = SUBMODEL_DETAILS.SUBMODEL_ID WHERE(BOOKING_DETAILS.STATUS = 'B')", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable getIssue_Details_ToIssue(string bid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT BOOKING_DETAILS.BOOKING_ID, SUBMODEL_DETAILS.SUBMODEL_NAME, MODEL_TABLE.MODEL_NAME, USER_DETAILS.FIRST_NAME, USER_DETAILS.LAST_NAME, BOOKING_DETAILS.STATUS, BOOKING_DETAILS.BALANCE_AMOUNT FROM BOOKING_DETAILS INNER JOIN USER_DETAILS ON BOOKING_DETAILS.USER_ID = USER_DETAILS.USER_ID INNER JOIN MODEL_TABLE ON BOOKING_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID INNER JOIN SUBMODEL_DETAILS ON BOOKING_DETAILS.SUBMODEL_ID = SUBMODEL_DETAILS.SUBMODEL_ID WHERE(BOOKING_DETAILS.STATUS = 'B') AND (BOOKING_DETAILS.BOOKING_ID = @bid)", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@bid", bid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public void update_booking_status(string bid,DateTime idate)
        {
            SqlCommand cmd = new SqlCommand("update BOOKING_DETAILS set STATUS='I',ISSUE_DATE=@idate where BOOKING_ID=@bid", sqlcon);
            cmd.Parameters.AddWithValue("@bid", bid);
            cmd.Parameters.AddWithValue("@idate",idate);
            cmd.ExecuteNonQuery();
        }

        public DataTable getSales_Details(DateTime fdate,DateTime tdate)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT PRICE_DETAILS.PRICE, BOOKING_DETAILS.ISSUE_DATE, BOOKING_DETAILS.STATUS, USER_DETAILS.FIRST_NAME, SUBMODEL_DETAILS.SUBMODEL_NAME, USER_DETAILS.LAST_NAME, MODEL_TABLE.MODEL_NAME FROM BOOKING_DETAILS INNER JOIN COLOR_DETAILS ON BOOKING_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID INNER JOIN USER_DETAILS ON BOOKING_DETAILS.USER_ID = USER_DETAILS.USER_ID INNER JOIN MODEL_TABLE ON BOOKING_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID INNER JOIN PRICE_DETAILS ON BOOKING_DETAILS.MODEL_ID = PRICE_DETAILS.MODEL_ID AND BOOKING_DETAILS.SUBMODEL_ID = PRICE_DETAILS.SUBMODEL_ID AND BOOKING_DETAILS.COLOR_ID = PRICE_DETAILS.COLOR_ID INNER JOIN SUBMODEL_DETAILS ON BOOKING_DETAILS.SUBMODEL_ID = SUBMODEL_DETAILS.SUBMODEL_ID WHERE(BOOKING_DETAILS.STATUS = 'I') AND (BOOKING_DETAILS.ISSUE_DATE BETWEEN @fdate AND @tdate)", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@fdate", fdate);
                Adpt.SelectCommand.Parameters.AddWithValue("@tdate", tdate);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }

        public DataTable getStatus_Details()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT [NUMBER],[MODEL_NAME],[STATUS],[SUBMODEL_NAME] FROM [CarSale].[dbo].[MOST_BOOKED_MODEL]", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable getCancel_Details()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                //Adpt = new SqlDataAdapter("SELECT PRICE_DETAILS.PRICE, BOOKING_DETAILS.STATUS, USER_DETAILS.FIRST_NAME, SUBMODEL_DETAILS.SUBMODEL_NAME, USER_DETAILS.LAST_NAME, MODEL_TABLE.MODEL_NAME FROM BOOKING_DETAILS INNER JOIN COLOR_DETAILS ON BOOKING_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID INNER JOIN USER_DETAILS ON BOOKING_DETAILS.USER_ID = USER_DETAILS.USER_ID INNER JOIN MODEL_TABLE ON BOOKING_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID INNER JOIN PRICE_DETAILS ON BOOKING_DETAILS.MODEL_ID = PRICE_DETAILS.MODEL_ID AND BOOKING_DETAILS.SUBMODEL_ID = PRICE_DETAILS.SUBMODEL_ID AND BOOKING_DETAILS.COLOR_ID = PRICE_DETAILS.COLOR_ID INNER JOIN SUBMODEL_DETAILS ON BOOKING_DETAILS.SUBMODEL_ID = SUBMODEL_DETAILS.SUBMODEL_ID WHERE(BOOKING_DETAILS.STATUS = 'C')", sqlcon);
                Adpt = new SqlDataAdapter("SELECT PRICE_DETAILS.PRICE, BOOKING_DETAILS.STATUS, USER_DETAILS.FIRST_NAME, SUBMODEL_DETAILS.SUBMODEL_NAME, USER_DETAILS.LAST_NAME, MODEL_TABLE.MODEL_NAME, PAYMENT_METHOD.ACCOUNT_INFO FROM BOOKING_DETAILS INNER JOIN COLOR_DETAILS ON BOOKING_DETAILS.COLOR_ID = COLOR_DETAILS.COLOR_ID INNER JOIN USER_DETAILS ON BOOKING_DETAILS.USER_ID = USER_DETAILS.USER_ID INNER JOIN MODEL_TABLE ON BOOKING_DETAILS.MODEL_ID = MODEL_TABLE.MODEL_ID INNER JOIN PRICE_DETAILS ON BOOKING_DETAILS.MODEL_ID = PRICE_DETAILS.MODEL_ID AND BOOKING_DETAILS.SUBMODEL_ID = PRICE_DETAILS.SUBMODEL_ID AND BOOKING_DETAILS.COLOR_ID = PRICE_DETAILS.COLOR_ID INNER JOIN SUBMODEL_DETAILS ON BOOKING_DETAILS.SUBMODEL_ID = SUBMODEL_DETAILS.SUBMODEL_ID INNER JOIN PAYMENT_METHOD ON USER_DETAILS.USER_ID = PAYMENT_METHOD.USER_ID WHERE(BOOKING_DETAILS.STATUS = 'C')", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public DataTable getModel_Photos()
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT * FROM MODEL_PHOTOS", sqlcon);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }

        public void model_photos_details(string mid, string pic1,string pic2,string pic3, string pic4)
        {
            SqlCommand cmd = new SqlCommand("insert into MODEL_PHOTOS values(@mid,@pic1,@pic2,@pic3,@pic4)", sqlcon);
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@pic1", pic1);
            cmd.Parameters.AddWithValue("@pic2", pic2);
            cmd.Parameters.AddWithValue("@pic3", pic3);
            cmd.Parameters.AddWithValue("@pic4", pic4);
            cmd.ExecuteNonQuery();
        }

        public DataTable getModel_Photos_Update(string mid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT * FROM MODEL_PHOTOS WHERE MODEL_ID=@mid", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@mid", mid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }

        public void update_model_photos(string mid, string pic1, string pic2, string pic3, string pic4)
        {
            SqlCommand cmd = new SqlCommand("UPDATE MODEL_PHOTOS SET MODEL_PHOTO1=@pic1,MODEL_PHOTO2=@pic2,MODEL_PHOTO3=@pic3,MODEL_PHOTO4=@pic4 WHERE MODEL_ID=@mid ", sqlcon);
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@pic1", pic1);
            cmd.Parameters.AddWithValue("@pic2", pic2);
            cmd.Parameters.AddWithValue("@pic3", pic3);
            cmd.Parameters.AddWithValue("@pic4", pic4);
            cmd.ExecuteNonQuery();
        }
        public int check3(string mid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT * FROM MODEL_PHOTOS WHERE MODEL_ID=@mid", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@mid", mid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt.Rows.Count;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return -1;
                throw ex;
            }

        }
        public void log_details(string lid,string aid, string name,string date,string login)
        {
            SqlCommand cmd = new SqlCommand("insert into ADMIN_LOG(LOG_ID,ADMIN_ID,ADMIN_NAME,DATE,LOGIN) values(@lid,@aid,@name,@date,@login)", sqlcon);
            cmd.Parameters.AddWithValue("@lid", lid);
            cmd.Parameters.AddWithValue("@aid", aid);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.ExecuteNonQuery();
        }

        public DataTable getAdmin_Log(string aid)
        {
            try
            {
                SqlDataAdapter Adpt = new SqlDataAdapter();
                Adpt = new SqlDataAdapter("SELECT * FROM ADMIN_LOG WHERE ADMIN_ID=@aid", sqlcon);
                Adpt.SelectCommand.Parameters.AddWithValue("@aid", aid);
                DataTable dt = new DataTable();
                Adpt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
                throw ex;
            }
        }
        public string inc10()
        {
            SqlCommand cmd = new SqlCommand("select isnull(max(LOG_ID)+1,1)from ADMIN_LOG", sqlcon);
            return cmd.ExecuteScalar().ToString();
        }

        public void update_log(string lid, string logout)
        {
            SqlCommand cmd = new SqlCommand("UPDATE ADMIN_LOG SET LOGOUT=@logout WHERE LOG_ID=@lid ", sqlcon);
            cmd.Parameters.AddWithValue("@lid", lid);
            cmd.Parameters.AddWithValue("@logout", logout);
            cmd.ExecuteNonQuery();
        }
    }
}