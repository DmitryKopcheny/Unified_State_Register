using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Unified_State_Register
{
    public class Database
    {
        private MySqlConnection _connection;
        public Database()
        {
            _connection = null;
        }
        public Database(MySqlConnection connection)
        {
            _connection = null;
            Open(connection);
        }
        public void Close()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection = null;
            }
        }
        public void Open(MySqlConnection connection)
        {
            Close();
            _connection = connection;
            _connection.Open();
        }
        public bool isConnected()
        {
            if (_connection == null)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        public void SignUp(User user)
        {
            MySqlCommand cmd = new MySqlCommand("sign_up_user", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("username", MySqlDbType.VarChar, 12);
            cmd.Parameters.Add("user_password", MySqlDbType.VarChar, 32);
            cmd.Parameters.Add("permission", MySqlDbType.VarChar, 1);
            cmd.Parameters.Add("passport_id", MySqlDbType.VarChar, 9);
            
            cmd.Parameters["username"].Value = user.Username;
            cmd.Parameters["user_password"].Value = user.Password;
            cmd.Parameters["permission"].Value = user.Permission;
            cmd.Parameters["passport_id"].Value = user.PassportId;

            cmd.Parameters["username"].Direction = ParameterDirection.Input;
            cmd.Parameters["user_password"].Direction = ParameterDirection.Input;
            cmd.Parameters["permission"].Direction = ParameterDirection.Input;
            cmd.Parameters["passport_id"].Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();
        }
        public User SignIn(User user)
        {
            MySqlCommand cmd = new MySqlCommand("sign_in_user", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("username", MySqlDbType.VarChar, 12);
            cmd.Parameters.Add("user_password", MySqlDbType.VarChar, 32);
            cmd.Parameters.Add("passport_id", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("permission", MySqlDbType.VarChar, 1);
            

            cmd.Parameters["username"].Value = user.Username;
            cmd.Parameters["user_password"].Value = user.Password;

            cmd.Parameters["username"].Direction = ParameterDirection.Input;
            cmd.Parameters["user_password"].Direction = ParameterDirection.Input;
            cmd.Parameters["passport_id"].Direction = ParameterDirection.Output;
            cmd.Parameters["permission"].Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            if (cmd.Parameters["passport_id"].Value == DBNull.Value)
            {
                return new User(user.Username,
                                user.Password,
                                null,
                                Convert.ToChar(cmd.Parameters["permission"].Value));
            }
            return new User(user.Username,
                                user.Password,
                                Convert.ToString(cmd.Parameters["passport_id"].Value),
                                Convert.ToChar(cmd.Parameters["permission"].Value));

        }
        public void RecordBirth(Dictionary<string, string> values)
        {
            MySqlCommand cmd = new MySqlCommand("record_birth", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("passport_id", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("place_of_reg", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("birth_cert_id", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("first_name", MySqlDbType.VarChar, 30);
            cmd.Parameters.Add("last_name", MySqlDbType.VarChar, 30);
            cmd.Parameters.Add("patronimic", MySqlDbType.VarChar, 30);
            cmd.Parameters.Add("passport_m", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("passport_f", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("date_of_birth", MySqlDbType.Date);
            cmd.Parameters.Add("sex", MySqlDbType.VarChar, 1);
            cmd.Parameters.Add("place_of_birth", MySqlDbType.VarChar, 255);

            cmd.Parameters["passport_id"].Value = values["passport"];
            cmd.Parameters["place_of_reg"].Value = values["agency"];
            cmd.Parameters["birth_cert_id"].Value = values["birth_cert"];
            cmd.Parameters["first_name"].Value = values["first_name"];
            cmd.Parameters["last_name"].Value = values["last_name"];
            cmd.Parameters["patronimic"].Value = values["patronimic"];
            cmd.Parameters["passport_m"].Value = values["mother"];
            cmd.Parameters["passport_f"].Value = values["father"];
            cmd.Parameters["date_of_birth"].Value = Convert.ToDateTime(values["date"]);
            cmd.Parameters["sex"].Value = Convert.ToString(values["sex"][0]);
            cmd.Parameters["place_of_birth"].Value = values["country"] + " " + values["region"] + " " + values["place"];

            cmd.Parameters["passport_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["place_of_reg"].Direction = ParameterDirection.Input;
            cmd.Parameters["birth_cert_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["first_name"].Direction = ParameterDirection.Input;
            cmd.Parameters["last_name"].Direction = ParameterDirection.Input;
            cmd.Parameters["patronimic"].Direction = ParameterDirection.Input;
            cmd.Parameters["passport_m"].Direction = ParameterDirection.Input;
            cmd.Parameters["passport_f"].Direction = ParameterDirection.Input;
            cmd.Parameters["date_of_birth"].Direction = ParameterDirection.Input;
            cmd.Parameters["sex"].Direction = ParameterDirection.Input;
            cmd.Parameters["place_of_birth"].Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();
        }
        public void RecordTaxpayer(Dictionary<string, string> values)
        {
            MySqlCommand cmd = new MySqlCommand("record_taxpayer_certificate", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("passport_id", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("taxpayer_id", MySqlDbType.VarChar, 10);
            cmd.Parameters.Add("fiscal_service_agency", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("form_id", MySqlDbType.VarChar, 10);
            
            cmd.Parameters["passport_id"].Value = values["passport"];
            cmd.Parameters["taxpayer_id"].Value = values["taxpayer"];
            cmd.Parameters["fiscal_service_agency"].Value = values["agency"];
            cmd.Parameters["form_id"].Value = values["form_id"];

            cmd.Parameters["passport_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["taxpayer_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["fiscal_service_agency"].Direction = ParameterDirection.Input;
            cmd.Parameters["form_id"].Direction = ParameterDirection.Input;
            if (cmd.Parameters["taxpayer_id"].Value == DBNull.Value)
                throw new Exception("taxpayer null");
            cmd.ExecuteNonQuery();
        }
        public void RecordLiveCertificate(Dictionary<string, string> values)
        {
            MySqlCommand cmd = new MySqlCommand("record_reference_from_usr", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("passport", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("record", MySqlDbType.VarChar, 13);
            cmd.Parameters.Add("reference_id", MySqlDbType.VarChar, 14);
            cmd.Parameters.Add("requested_statements", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("place_of_issue", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("place_of_reg", MySqlDbType.VarChar, 255);

            cmd.Parameters["passport"].Value = values["passport"];
            cmd.Parameters["record"].Value = values["record"];
            cmd.Parameters["reference_id"].Value = values["reference"];
            cmd.Parameters["requested_statements"].Value = values["statements"];
            cmd.Parameters["place_of_issue"].Value = values["issue"];
            cmd.Parameters["place_of_reg"].Value = values["region"] + " " + values["place_type"] + " " + values["place"] + " " + values["street"] + " " + values["house"] + " " + values["appartment"];

            cmd.Parameters["passport"].Direction = ParameterDirection.Input;
            cmd.Parameters["record"].Direction = ParameterDirection.Input;
            cmd.Parameters["reference_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["requested_statements"].Direction = ParameterDirection.Input;
            cmd.Parameters["place_of_issue"].Direction = ParameterDirection.Input;
            cmd.Parameters["place_of_reg"].Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();
        }
        public void RecordPassport(Dictionary<string, string> values)
        {
            MySqlCommand cmd = new MySqlCommand("record_passport", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("passport_id", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("first_name", MySqlDbType.VarChar, 30);
            cmd.Parameters.Add("last_name", MySqlDbType.VarChar, 30);
            cmd.Parameters.Add("patronimic", MySqlDbType.VarChar, 30);
            cmd.Parameters.Add("sex", MySqlDbType.VarChar, 1);
            cmd.Parameters.Add("date_of_issue", MySqlDbType.Date);
            cmd.Parameters.Add("agency_id", MySqlDbType.VarChar, 4);
            cmd.Parameters.Add("birth_cert_id", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("taxpayer_id", MySqlDbType.VarChar, 10);
            cmd.Parameters.Add("record_id", MySqlDbType.VarChar, 13);

            cmd.Parameters["passport_id"].Value = values["passport"];
            cmd.Parameters["first_name"].Value = values["first_name"];
            cmd.Parameters["last_name"].Value = values["last_name"];
            cmd.Parameters["patronimic"].Value = values["patronimic"];
            cmd.Parameters["sex"].Value = Convert.ToString(values["sex"][0]);
            cmd.Parameters["date_of_issue"].Value = Convert.ToDateTime(values["date"]);
            cmd.Parameters["agency_id"].Value = values["agency"];
            cmd.Parameters["birth_cert_id"].Value = values["birth_cert"];
            cmd.Parameters["taxpayer_id"].Value = values["taxpayer"];
            cmd.Parameters["record_id"].Value = values["place"];

            cmd.Parameters["passport_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["first_name"].Direction = ParameterDirection.Input;
            cmd.Parameters["last_name"].Direction = ParameterDirection.Input;
            cmd.Parameters["patronimic"].Direction = ParameterDirection.Input;
            cmd.Parameters["sex"].Direction = ParameterDirection.Input;
            cmd.Parameters["date_of_issue"].Direction = ParameterDirection.Input;
            cmd.Parameters["agency_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["birth_cert_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["taxpayer_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["record_id"].Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();
        }

        public void RecordMarriage(Dictionary<string, string> values)
        {
            MySqlCommand cmd = new MySqlCommand("record_marriage", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("passport_h", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("passport_w", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("reg_place", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("agency", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("act_id", MySqlDbType.Int32);

            cmd.Parameters["passport_h"].Value = values["husband"];
            cmd.Parameters["passport_w"].Value = values["wife"];
            cmd.Parameters["reg_place"].Value = values["place"];
            cmd.Parameters["agency"].Value = values["agency"];
            cmd.Parameters["act_id"].Value = Convert.ToInt32(values["act"]);

            cmd.Parameters["passport_h"].Direction = ParameterDirection.Input;
            cmd.Parameters["passport_w"].Direction = ParameterDirection.Input;
            cmd.Parameters["reg_place"].Direction = ParameterDirection.Input;
            cmd.Parameters["agency"].Direction = ParameterDirection.Input;
            cmd.Parameters["act_id"].Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();
        }
        public void RecordPropertyOwnership(Dictionary<string, string> values)
        {
            MySqlCommand cmd = new MySqlCommand("record_property_right_certificate", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("document_id", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("agency", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("registrar_passport_id", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("ownership_reason", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("issue_reason", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("ownership_form", MySqlDbType.VarChar, 1);
            cmd.Parameters.Add("share_size", MySqlDbType.Int32);
            cmd.Parameters.Add("passport_id", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("property_object", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("object_id", MySqlDbType.Int32);
            cmd.Parameters.Add("adress", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("cadastral_id", MySqlDbType.VarChar, 19);
            cmd.Parameters.Add("object_reg_date", MySqlDbType.Date);

            cmd.Parameters["document_id"].Value = values["doc_id"];
            cmd.Parameters["agency"].Value = values["agency"];
            cmd.Parameters["registrar_passport_id"].Value = values["registrar"];
            cmd.Parameters["ownership_reason"].Value = values["reason"];
            cmd.Parameters["issue_reason"].Value = values["issue"];
            cmd.Parameters["ownership_form"].Value = Convert.ToString(values["form"][0]);
            cmd.Parameters["share_size"].Value = Convert.ToInt32(values["share"]);
            cmd.Parameters["passport_id"].Value = values["passport"];
            cmd.Parameters["property_object"].Value = values["object"];
            cmd.Parameters["object_id"].Value = Convert.ToInt32(values["object_id"]);
            cmd.Parameters["adress"].Value = values["adress"];
            cmd.Parameters["cadastral_id"].Value = values["cadastral"];
            cmd.Parameters["object_reg_date"].Value = Convert.ToDateTime(values["date"]);

            cmd.Parameters["document_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["agency"].Direction = ParameterDirection.Input;
            cmd.Parameters["registrar_passport_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["ownership_reason"].Direction = ParameterDirection.Input;
            cmd.Parameters["issue_reason"].Direction = ParameterDirection.Input;
            cmd.Parameters["share_size"].Direction = ParameterDirection.Input;
            cmd.Parameters["passport_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["property_object"].Direction = ParameterDirection.Input;
            cmd.Parameters["object_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["ownership_form"].Direction = ParameterDirection.Input;
            cmd.Parameters["adress"].Direction = ParameterDirection.Input;
            cmd.Parameters["cadastral_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["object_reg_date"].Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();
        }
        public void RecordCarOwnership(Dictionary<string, string> values)
        {
            MySqlCommand cmd = new MySqlCommand("record_transport_registration_certificate", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("passport_id", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("issue_year", MySqlDbType.VarChar, 4);
            cmd.Parameters.Add("reg_id", MySqlDbType.VarChar, 8);

            cmd.Parameters["passport_id"].Value = values["passport"];
            cmd.Parameters["issue_year"].Value = values["year"];
            cmd.Parameters["reg_id"].Value = values["number"];

            cmd.Parameters["passport_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["issue_year"].Direction = ParameterDirection.Input;
            cmd.Parameters["reg_id"].Direction = ParameterDirection.Input;
            cmd.ExecuteNonQuery();
        }
        public void RecordDeath(Dictionary<string, string> values)
        {
            MySqlCommand cmd = new MySqlCommand("record_death", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("passport_id", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("document_id", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("reg_place", MySqlDbType.VarChar, 255);
            cmd.Parameters.Add("agency", MySqlDbType.VarChar, 255);

            cmd.Parameters["passport_id"].Value = values["passport"];
            cmd.Parameters["document_id"].Value = values["cert"];
            cmd.Parameters["reg_place"].Value = values["place"];
            cmd.Parameters["agency"].Value = values["agency"];

            cmd.Parameters["passport_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["document_id"].Direction = ParameterDirection.Input;
            cmd.Parameters["reg_place"].Direction = ParameterDirection.Input;
            cmd.Parameters["agency"].Direction = ParameterDirection.Input;

            cmd.ExecuteNonQuery();
        }
        public MySqlDataReader CreateReaderOnPassportData(Dictionary<string, string> values)
        {
            MySqlCommand cmd = new MySqlCommand("find_passport_data", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("passport", MySqlDbType.VarChar, 9);
            cmd.Parameters.Add("tax", MySqlDbType.VarChar, 10);
            cmd.Parameters.Add("ref", MySqlDbType.VarChar, 13);
            cmd.Parameters.Add("first_name", MySqlDbType.VarChar, 30);
            cmd.Parameters.Add("last_name", MySqlDbType.VarChar, 30);
            cmd.Parameters.Add("patronimic", MySqlDbType.VarChar, 30);
            cmd.Parameters.Add("place", MySqlDbType.VarChar, 255);

            cmd.Parameters["passport"].Value = values["passport"];
            cmd.Parameters["tax"].Value = values["taxpayer"];
            cmd.Parameters["ref"].Value = values["reference"];
            cmd.Parameters["first_name"].Value = values["first_name"];
            cmd.Parameters["last_name"].Value = values["last_name"];
            cmd.Parameters["patronimic"].Value = values["patronimic"];
            cmd.Parameters["place"].Value = values["place"];

            cmd.Parameters["passport"].Direction = ParameterDirection.Input;
            cmd.Parameters["tax"].Direction = ParameterDirection.Input;
            cmd.Parameters["ref"].Direction = ParameterDirection.Input;
            cmd.Parameters["first_name"].Direction = ParameterDirection.Input;
            cmd.Parameters["last_name"].Direction = ParameterDirection.Input;
            cmd.Parameters["patronimic"].Direction = ParameterDirection.Input;
            cmd.Parameters["place"].Direction = ParameterDirection.Input;

            return cmd.ExecuteReader();
        }
        public MySqlDataReader CreateReaderOnTransport(string registrationId)
        {
            MySqlCommand cmd = new MySqlCommand("find_car_by_registration_id", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("reg_id", MySqlDbType.VarChar, 8);

            cmd.Parameters["reg_id"].Value = registrationId;

            cmd.Parameters["reg_id"].Direction = ParameterDirection.Input;

            return cmd.ExecuteReader();
        }
        public MySqlDataReader CreateReaderOnProperty(string DocumentId)
        {
            MySqlCommand cmd = new MySqlCommand("find_property_by_owner_passport_id", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("passport", MySqlDbType.VarChar, 9);

            cmd.Parameters["passport"].Value = DocumentId;

            cmd.Parameters["passport"].Direction = ParameterDirection.Input;

            return cmd.ExecuteReader();
        }
        public MySqlDataReader CreateReaderOnOffspring(string DocumentId)
        {
            MySqlCommand cmd = new MySqlCommand("find_children_by_dead_parent", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("doc_id", MySqlDbType.VarChar, 9);

            cmd.Parameters["doc_id"].Value = DocumentId;

            cmd.Parameters["doc_id"].Direction = ParameterDirection.Input;

            return cmd.ExecuteReader();
        }
        public MySqlDataReader CreateReaderForPassportReport(string PassportId)
        {
            MySqlCommand cmd = new MySqlCommand("get_passport", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("passport", MySqlDbType.VarChar, 9);

            cmd.Parameters["passport"].Value = PassportId;

            cmd.Parameters["passport"].Direction = ParameterDirection.Input;

            return cmd.ExecuteReader();
        }
        public MySqlDataReader CreateReaderForTaxpayerReport(string PassportId)
        {
            MySqlCommand cmd = new MySqlCommand("get_taxpayer_certificate", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("passport", MySqlDbType.VarChar, 9);

            cmd.Parameters["passport"].Value = PassportId;

            cmd.Parameters["passport"].Direction = ParameterDirection.Input;

            return cmd.ExecuteReader();
        }
        public MySqlDataReader CreateReaderForReferenceFromUSRReport(string PassportId)
        {
            MySqlCommand cmd = new MySqlCommand("get_reference_from_usr", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("passport", MySqlDbType.VarChar, 9);

            cmd.Parameters["passport"].Value = PassportId;

            cmd.Parameters["passport"].Direction = ParameterDirection.Input;

            return cmd.ExecuteReader();
        }
        public MySqlDataReader CreateReaderForBirthCertificateReport(string PassportId)
        {
            MySqlCommand cmd = new MySqlCommand("get_birth_certificate", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("passport", MySqlDbType.VarChar, 9);

            cmd.Parameters["passport"].Value = PassportId;

            cmd.Parameters["passport"].Direction = ParameterDirection.Input;

            return cmd.ExecuteReader();
        }
        public MySqlDataReader CreateReaderForMarriageCertificateReport(string PassportId)
        {
            MySqlCommand cmd = new MySqlCommand("get_marriage_certificate", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("passport", MySqlDbType.VarChar, 9);

            cmd.Parameters["passport"].Value = PassportId;

            cmd.Parameters["passport"].Direction = ParameterDirection.Input;

            return cmd.ExecuteReader();
        }
        public MySqlDataReader CreateReaderForPropertyRightCertificateReport(string PassportId)
        {
            MySqlCommand cmd = new MySqlCommand("get_property_ownership_certificate", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("passport", MySqlDbType.VarChar, 9);

            cmd.Parameters["passport"].Value = PassportId;

            cmd.Parameters["passport"].Direction = ParameterDirection.Input;

            return cmd.ExecuteReader();
        }
        public MySqlDataReader CreateReaderForTransportCertificateReport(string PassportId)
        {
            MySqlCommand cmd = new MySqlCommand("get_transport_certificate", _connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("passport", MySqlDbType.VarChar, 9);

            cmd.Parameters["passport"].Value = PassportId;

            cmd.Parameters["passport"].Direction = ParameterDirection.Input;

            return cmd.ExecuteReader();
        }

        public List<string[]> ReadTransportCertificateForReport(string PassportId)
        {
            const int transportCertificateReaderFieldsAmount = 6;
            List<string[]> results = new List<string[]>();
            using (MySqlDataReader reader = CreateReaderForTransportCertificateReport(PassportId))
            {
                if (reader == null)
                {
                    throw new Exception("Reader is not set");
                }
                if (!reader.HasRows)
                {
                    throw new Exception("Нічого не знайдено");
                }
                while (reader.Read())
                {
                    results.Add(new string[transportCertificateReaderFieldsAmount]);
                    for (int i = 0; i < transportCertificateReaderFieldsAmount; ++i)
                    {
                        results[results.Count - 1][i] = reader[i].ToString();
                    }
                }
            }
            return results;
        }
        public List<string[]> ReadPropertyRightCertificateForReport(string PassportId)
        {
            const int propertyRightCertificateReaderFieldsAmount = 15;
            List<string[]> results = new List<string[]>();
            using (MySqlDataReader reader = CreateReaderForPropertyRightCertificateReport(PassportId))
            {
                if (reader == null)
                {
                    throw new Exception("Reader is not set");
                }
                if (!reader.HasRows)
                {
                    throw new Exception("Нічого не знайдено");
                }
                while (reader.Read())
                {
                    results.Add(new string[propertyRightCertificateReaderFieldsAmount]);
                    for (int i = 0; i < propertyRightCertificateReaderFieldsAmount; ++i)
                    {
                        results[results.Count - 1][i] = reader[i].ToString();
                    }
                }
            }
            return results;
        }
        public List<string> ReadMarriageCertificateForReport(string PassportId)
        {
            const int marriageCertificateReaderFieldsAmount = 12;
            List<string> results = new List<string>();
            using (MySqlDataReader reader = CreateReaderForMarriageCertificateReport(PassportId))
            {
                if (reader == null)
                {
                    throw new Exception("Reader is not set");
                }
                if (!reader.HasRows)
                {
                    throw new Exception("Нічого не знайдено");
                }
                while (reader.Read())
                {
                    for (int i = 0; i < marriageCertificateReaderFieldsAmount; ++i)
                    {
                        results.Add(reader[i].ToString());
                    }
                }
            }
            return results;
        }
        public List<string> ReadBirthCertificateForReport(string PassportId)
        {
            const int birthCertificateReaderFieldsAmount = 7;
            List<string> results = new List<string>();
            using (MySqlDataReader reader = CreateReaderForBirthCertificateReport(PassportId))
            {
                if (reader == null)
                {
                    throw new Exception("Reader is not set");
                }
                if (!reader.HasRows)
                {
                    throw new Exception("Нічого не знайдено");
                }
                while (reader.Read())
                {
                    for (int i = 0; i < birthCertificateReaderFieldsAmount; ++i)
                    {
                        results.Add(reader[i].ToString());
                    }
                }
            }
            return results;
        }
        public List<string> ReadReferenceFromUSRForReport(string PassportId)
        {
            const int referenceFromUSRReaderFieldsAmount = 9;
            List<string> results = new List<string>();
            using (MySqlDataReader reader = CreateReaderForReferenceFromUSRReport(PassportId))
            {
                if (reader == null)
                {
                    throw new Exception("Reader is not set");
                }
                if (!reader.HasRows)
                {
                    throw new Exception("Нічого не знайдено");
                }
                while (reader.Read())
                {
                    for (int i = 0; i < referenceFromUSRReaderFieldsAmount; ++i)
                    {
                        results.Add(reader[i].ToString());
                    }
                }
            }
            return results;
        }
        public List<string> ReadTaxpayerCertificateForReport(string PassportId)
        {
            const int taxpayerCertificateReaderFieldsAmount = 6;
            List<string> results = new List<string>();
            using (MySqlDataReader reader = CreateReaderForTaxpayerReport(PassportId))
            {
                if (reader == null)
                {
                    throw new Exception("Reader is not set");
                }
                if (!reader.HasRows)
                {
                    throw new Exception("Нічого не знайдено");
                }
                while (reader.Read())
                {
                    for (int i = 0; i < taxpayerCertificateReaderFieldsAmount; ++i)
                    {
                        results.Add(reader[i].ToString());
                    }
                }
            }
            return results;
        }
        public List<string> ReadPassportForReport(string PassportId)
        {
            const int passportReaderFieldsAmount = 12;
            List<string> results = new List<string>();
            using (MySqlDataReader reader = CreateReaderForPassportReport(PassportId))
            {
                if (reader == null)
                {
                    throw new Exception("Reader is not set");
                }
                if (!reader.HasRows)
                {
                    throw new Exception("Нічого не знайдено");
                }
                while (reader.Read())
                {
                    for (int i = 0; i < passportReaderFieldsAmount; ++i)
                    {
                        results.Add(reader[i].ToString());
                    }
                }
            }
            return results;
        }
        public List<string[]> ReadOffspringData(string deathDocumentId)
        {
            const int offspringDataReaderFieldsAmount = 11;
            List<string[]> results = new List<string[]>();
            using (MySqlDataReader reader = CreateReaderOnOffspring(deathDocumentId))
            {
                if (reader == null)
                {
                    throw new Exception("Reader is not set");
                }
                if (!reader.HasRows)
                {
                    throw new Exception("Нічого не знайдено");
                }
                while (reader.Read())
                {
                    results.Add(new string[offspringDataReaderFieldsAmount]);
                    for (int i = 0; i < offspringDataReaderFieldsAmount; ++i)
                    {
                        results[results.Count - 1][i] = reader[i].ToString();
                    }
                }
            }
            return results;
        }
        public List<string[]> ReadPropertyData(string propertyDocumentId)
        {
            const int propertyDataReaderFieldsAmount = 14;
            List<string[]> results = new List<string[]>();
            using (MySqlDataReader reader = CreateReaderOnProperty(propertyDocumentId))
            {
                if (reader == null)
                {
                    throw new Exception("Reader is not set");
                }
                if (!reader.HasRows)
                {
                    throw new Exception("Нічого не знайдено");
                }
                while (reader.Read())
                {
                    results.Add(new string[propertyDataReaderFieldsAmount]);
                    for (int i = 0; i < propertyDataReaderFieldsAmount; ++i)
                    {
                        results[results.Count - 1][i] = reader[i].ToString();
                    }
                }
            }
            return results;
        }
        public List<string[]> ReadTransportData(string registrationId)
        {
            const int transportDataReaderFieldsAmount = 5;
            List<string[]> results = new List<string[]>();
            using (MySqlDataReader reader = CreateReaderOnTransport(registrationId))
            {
                if (reader == null)
                {
                    throw new Exception("Reader is not set");
                }
                if (!reader.HasRows)
                {
                    throw new Exception("Нічого не знайдено");
                }
                while (reader.Read())
                {
                    results.Add(new string[transportDataReaderFieldsAmount]);
                    for (int i = 0; i < transportDataReaderFieldsAmount; ++i)
                    {
                        results[results.Count - 1][i] = reader[i].ToString();
                    }
                }
            }
            return results;
        }
        public List<string[]> ReadPassportData(Dictionary<string, string> values)
        {
            const int passportDataReaderFieldsAmount = 24;
            List<string[]> results = new List<string[]>();
            using (MySqlDataReader reader = CreateReaderOnPassportData(values))
            {
                if (reader == null)
                {
                    throw new Exception("Reader is not set");
                }
                if (!reader.HasRows)
                {
                    throw new Exception("Нічого не знайдено");
                }
                while (reader.Read())
                {
                    results.Add(new string[passportDataReaderFieldsAmount]);
                    for (int i = 0; i < passportDataReaderFieldsAmount; ++i)
                    {
                        results[results.Count - 1][i] = reader[i].ToString();
                    }
                }
            }
            return results;
        }
    }
}
