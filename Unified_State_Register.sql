-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: unified_state_register
-- ------------------------------------------------------
-- Server version	8.0.25
drop schema `unified_state_register`;
create schema `unified_state_register` default character set utf8;
use unified_state_register;
/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `arch_birth_certificate`
--

DROP TABLE IF EXISTS `arch_birth_certificate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `arch_birth_certificate` (
  `Birth_Certificate_Id` char(9) NOT NULL,
  `Date_of_Birth` date DEFAULT NULL,
  `Passport_Id_Father` char(9) DEFAULT NULL,
  `Passport_Id_Mother` char(9) DEFAULT NULL,
  `Place_of_Birth` varchar(255) DEFAULT NULL,
  `Place_of_Registration` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Birth_Certificate_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arch_birth_certificate`
--

LOCK TABLES `arch_birth_certificate` WRITE;
/*!40000 ALTER TABLE `arch_birth_certificate` DISABLE KEYS */;
INSERT INTO `arch_birth_certificate` VALUES ('444010171','1992-04-23','888696958','888696958','УКРАЇНА ЗАПОРІЗЬКА ОБЛАСТЬ ЗАПОРІЖЖЯ','Відділ реєстрації актів районого управління юстиції'),('777000258','1940-12-12','777456654','777159951','УКРАЇНА ЗАПОРІЗЬКА ОБЛАСТЬ ЗАПОРІЖЖЯ','Відділ реєстрації актів районого управління юстиції'),('777000852','1940-12-12','777845962','777147123','УКРАЇНА ЗАПОРІЗЬКА ОБЛАСТЬ ЗАПОРІЖЖЯ','Відділ реєстрації актів районого управління юстиції'),('888000699','1941-12-12','888111222','888222111','УКРАЇНА ЗАПОРІЗЬКА ОБЛАСТЬ ЗАПОРІЖЖЯ','Відділ реєстрації актів районого управління юстиції'),('888000958','1942-12-12','888455465','888122123','УКРАЇНА ЗАПОРІЗЬКА ОБЛАСТЬ ЗАПОРІЖЖЯ','Відділ реєстрації актів районого управління юстиції');
/*!40000 ALTER TABLE `arch_birth_certificate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `arch_marriage_certificate`
--

DROP TABLE IF EXISTS `arch_marriage_certificate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `arch_marriage_certificate` (
  `Arch_Doc_Id` bigint NOT NULL AUTO_INCREMENT,
  `Arch_Date` date DEFAULT NULL,
  `First_Passport_Id` char(9) DEFAULT NULL,
  `Second_Passport_Id` char(9) DEFAULT NULL,
  `Registration_Date` date DEFAULT NULL,
  `Act_Id` int DEFAULT NULL,
  `First_Lastname_Before` varchar(30) DEFAULT NULL,
  `First_Lastname_After` varchar(30) DEFAULT NULL,
  `Second_Lastname_Before` varchar(30) DEFAULT NULL,
  `Second_Lastname_After` varchar(30) DEFAULT NULL,
  `Registration_Place` varchar(255) DEFAULT NULL,
  `Agency` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Arch_Doc_Id`),
  KEY `First_Passport_Id` (`First_Passport_Id`),
  KEY `Second_Passport_Id` (`Second_Passport_Id`),
  CONSTRAINT `arch_marriage_certificate_ibfk_1` FOREIGN KEY (`First_Passport_Id`) REFERENCES `arch_unified_passport_id` (`Passport_Id`),
  CONSTRAINT `arch_marriage_certificate_ibfk_2` FOREIGN KEY (`Second_Passport_Id`) REFERENCES `arch_unified_passport_id` (`Passport_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arch_marriage_certificate`
--

LOCK TABLES `arch_marriage_certificate` WRITE;
/*!40000 ALTER TABLE `arch_marriage_certificate` DISABLE KEYS */;
INSERT INTO `arch_marriage_certificate` VALUES (7,'2021-06-04','888223699','888696958','2021-06-03',2587,'Стрельченко','Стрельченко','Широкобокова','Стрельченко','Запорізький міський відділ реєстраціії актів цивільного стану','Запорізький міський відділ реєстраціії актів цивільного стану'),(8,'2021-06-04','777698258','777369852','2021-06-03',5648,'Васильченко','Васильченко','Міщенко','Васильченко','Запорізький міський відділ реєстраціії актів цивільного стану','Запорізький міський відділ реєстраціії актів цивільного стану'),(9,'2021-06-13','444589632','444582271','2021-06-03',1233,'Васильченко','Васильченко','Стрельченко','Васильченко','Запорізький міський відділ реєстраціії актів цивільного стану','Запорізький міський відділ реєстраціії актів цивільного стану');
/*!40000 ALTER TABLE `arch_marriage_certificate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `arch_passport`
--

DROP TABLE IF EXISTS `arch_passport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `arch_passport` (
  `Arch_Doc_Id` bigint NOT NULL AUTO_INCREMENT,
  `Arch_Date` date DEFAULT NULL,
  `Passport_Id` char(9) DEFAULT NULL,
  `First_Name` varchar(30) DEFAULT NULL,
  `Last_Name` varchar(30) DEFAULT NULL,
  `Patronymic` varchar(30) DEFAULT NULL,
  `Sex` char(1) DEFAULT NULL,
  `Date_of_Issue` date DEFAULT NULL,
  `Validity_Date` date DEFAULT NULL,
  `Agency_Id` char(4) DEFAULT NULL,
  `Taxpayer_Id` char(10) DEFAULT NULL,
  `Birth_Certificate_Id` char(9) DEFAULT NULL,
  `Record_Id` bigint DEFAULT NULL,
  PRIMARY KEY (`Arch_Doc_Id`),
  UNIQUE KEY `Record_Id` (`Record_Id`),
  KEY `Passport_Id` (`Passport_Id`),
  KEY `Birth_Certificate_Id_i` (`Birth_Certificate_Id`),
  KEY `Record_Id_i` (`Record_Id`),
  KEY `Taxpayer_Id_i` (`Taxpayer_Id`),
  CONSTRAINT `arch_passport_ibfk_1` FOREIGN KEY (`Passport_Id`) REFERENCES `arch_unified_passport_id` (`Passport_Id`),
  CONSTRAINT `arch_passport_ibfk_2` FOREIGN KEY (`Birth_Certificate_Id`) REFERENCES `arch_birth_certificate` (`Birth_Certificate_Id`),
  CONSTRAINT `arch_passport_ibfk_3` FOREIGN KEY (`Record_Id`) REFERENCES `arch_reference_from_usr` (`Arch_Doc_Id`),
  CONSTRAINT `arch_passport_ibfk_4` FOREIGN KEY (`Taxpayer_Id`) REFERENCES `arch_taxpayer_certificate` (`Taxpayer_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arch_passport`
--

LOCK TABLES `arch_passport` WRITE;
/*!40000 ALTER TABLE `arch_passport` DISABLE KEYS */;
INSERT INTO `arch_passport` VALUES (1,'2021-06-03','444589632','Антон','Васильченко','Антонович','Ч',NULL,NULL,NULL,'0014258655','444589000',NULL),(8,'2021-06-03','444582271','Юлія','Стрельченко','Олександрівна','Ж','2014-05-17','2024-05-17','1223','9874895123','444010171',NULL),(9,NULL,'555487123','Микита','Резніченко','Сергійович','Ч',NULL,NULL,NULL,'4862753951','555000123',NULL),(10,NULL,'666548951','Марія','Слюсаренко','Генадієвна','Ж',NULL,NULL,NULL,'3696399630','666000951',NULL),(11,NULL,'777369852','Гання','Міщенко','Ярославівна','Ж',NULL,NULL,NULL,'7899877899','777000852',NULL),(12,NULL,'777698258','Антон','Васильченко','Ігорович','Ч',NULL,NULL,NULL,'4123321123','777000258',NULL),(13,NULL,'888223699','Валерій','Стрельченко','Михайлович','Ч',NULL,NULL,NULL,'8527419630','888000699',NULL),(14,NULL,'888696958','Олександра','Широкобокова','Костянтинівна','Ж',NULL,NULL,NULL,'5444248126','888000958',NULL),(19,'2021-06-04','888223699','Валерій','Стрельченко','Михайлович','Ч','2009-07-01','2019-07-01','1223','8527419630','888000699',5),(20,NULL,'777698258','Антон','Васильченко','Ігорович','Ч','2018-07-01','2028-07-01','1223','4123321123','777000258',NULL),(21,NULL,'777369852','Ганна','Міщенко','Ярославівна','Ж','1958-07-01','1968-07-01','1223','7899877899','777000852',NULL),(22,NULL,'888696958','Олекссандра','Широкобокова','Костянтинівна','Ж','1959-07-01','1969-07-01','1223','5444248126','888000958',NULL),(23,NULL,'777369852','Ганна','Васильченко','Ярославівна','Ж','1965-07-16','1975-07-16','1223','7899877899','777000852',NULL),(24,NULL,'888696958','Олександра','Стрельченко','Костянтинівна','Ж','1965-07-16','1975-07-16','1223','5444248126','888000958',NULL),(25,'2021-06-07','000111222','Михайло','Ковальов','Михайлович','Ч',NULL,NULL,NULL,'0001112220','000111000',NULL),(31,'2021-06-13','000123321','Марія','Васильченко','Антоновна','Ж',NULL,NULL,NULL,'3213213210','000123320',NULL),(32,NULL,'000123321','Марія','Васильченко','Антоновна','Ж','2017-06-13','2027-06-13','1223','3213213210','000123320',NULL),(33,NULL,'444582271','Юлія','Стрельченко','Олександрівна','Ж','2014-05-17','2024-05-17','1223','9874895123','444010171',NULL);
/*!40000 ALTER TABLE `arch_passport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `arch_property_right_certificate`
--

DROP TABLE IF EXISTS `arch_property_right_certificate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `arch_property_right_certificate` (
  `Arch_Date` date DEFAULT NULL,
  `Document_Id` char(9) NOT NULL,
  `Registration_Date` date DEFAULT NULL,
  `Agency` varchar(255) DEFAULT NULL,
  `Registrar_Passport_Id` char(9) DEFAULT NULL,
  `Ownership_Reason` varchar(255) DEFAULT NULL,
  `Issue_Reason` varchar(255) DEFAULT NULL,
  `Ownership_Form` char(1) DEFAULT NULL,
  `Share_Size` int DEFAULT NULL,
  `Owner_Passport_Id` char(9) DEFAULT NULL,
  `Property_Object` varchar(255) DEFAULT NULL,
  `Object_Id` int DEFAULT NULL,
  `Adress` varchar(255) DEFAULT NULL,
  `Cadastral_Id` char(19) DEFAULT NULL,
  `Object_Regestration_Date` date DEFAULT NULL,
  PRIMARY KEY (`Document_Id`),
  KEY `Owner_Passport_Id` (`Owner_Passport_Id`),
  CONSTRAINT `arch_property_right_certificate_ibfk_1` FOREIGN KEY (`Owner_Passport_Id`) REFERENCES `arch_unified_passport_id` (`Passport_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arch_property_right_certificate`
--

LOCK TABLES `arch_property_right_certificate` WRITE;
/*!40000 ALTER TABLE `arch_property_right_certificate` DISABLE KEYS */;
/*!40000 ALTER TABLE `arch_property_right_certificate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `arch_reference_from_usr`
--

DROP TABLE IF EXISTS `arch_reference_from_usr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `arch_reference_from_usr` (
  `Arch_Doc_Id` bigint NOT NULL AUTO_INCREMENT,
  `Arch_Date` date DEFAULT NULL,
  `Record_Id` char(13) DEFAULT NULL,
  `Reference_Id` char(14) DEFAULT NULL,
  `Place_of_Registration` varchar(255) DEFAULT NULL,
  `Place_of_Issue` varchar(255) DEFAULT NULL,
  `Registration_Date` date DEFAULT NULL,
  `Requested_Statements` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Arch_Doc_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arch_reference_from_usr`
--

LOCK TABLES `arch_reference_from_usr` WRITE;
/*!40000 ALTER TABLE `arch_reference_from_usr` DISABLE KEYS */;
INSERT INTO `arch_reference_from_usr` VALUES (5,'2021-06-04','4444147774111','44441477741110','ЗАПОРІЗЬКА ОБЛАСТЬ М. ЗАПОРІЖЖЯ РАДІО 47 1','Комунарський районий відділ у місті Запоріжжі Управління Державної міграційної служби України в Запорізькій області','2021-06-02','Місце проживання'),(6,NULL,'3526845712452','35268457124520','ЗАПОРІЗЬКА ОБЛАСТЬ М. ЗАПОРІЖЖЯ КОСМІЧНА 112 12','Комунарський районий відділ у місті Запоріжжі Управління Державної міграційної служби України в Запорізькій області','2021-06-02','Місце проживання'),(7,NULL,'1233654478990','12336544789900','ЗАПОРІЗЬКА ОБЛАСТЬ М. ЗАПОРІЖЖЯ КОСМІЧНА 112 12','Комунарський районий відділ у місті Запоріжжі Управління Державної міграційної служби України в Запорізькій області','2021-06-02','Місце проживання'),(8,NULL,'3333125474580','33331254745800','ЗАПОРІЗЬКА ОБЛАСТЬ М. ЗАПОРІЖЖЯ РАДІО 47 1','Комунарський районий відділ у місті Запоріжжі Управління Державної міграційної служби України в Запорізькій області','2021-06-02','Місце проживання'),(12,'2021-06-13','1542754886592','15427548865920','ЗАПОРІЗЬКА ОБЛАСТЬ  ЗАПОРІЖЖЯ КОСМІЧНА 112 12','Комунарський районий відділ у місті Запоріжжі Управління Державної міграційної служби України в Запорізькій області','2021-06-02','Місце проживання');
/*!40000 ALTER TABLE `arch_reference_from_usr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `arch_taxpayer_certificate`
--

DROP TABLE IF EXISTS `arch_taxpayer_certificate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `arch_taxpayer_certificate` (
  `Taxpayer_Id` char(10) NOT NULL,
  `Registration_Date` date DEFAULT NULL,
  `Fiscal_Service_Agency` varchar(255) DEFAULT NULL,
  `Form_Id` char(10) DEFAULT NULL,
  PRIMARY KEY (`Taxpayer_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arch_taxpayer_certificate`
--

LOCK TABLES `arch_taxpayer_certificate` WRITE;
/*!40000 ALTER TABLE `arch_taxpayer_certificate` DISABLE KEYS */;
INSERT INTO `arch_taxpayer_certificate` VALUES ('0011223301','2021-06-10','001122330001122330','0011223301'),('4123321123','2021-06-02','ДПІ У КОМУНАРСЬКОМУ РАЙОНІ М. ЗАПОРІЖЖЯ ГУ ДФС','4123321000'),('5444248126','2021-06-02','ДПІ У КОМУНАРСЬКОМУ РАЙОНІ М. ЗАПОРІЖЖЯ ГУ ДФС','5444248000'),('7899877899','2021-06-02','ДПІ У КОМУНАРСЬКОМУ РАЙОНІ М. ЗАПОРІЖЖЯ ГУ ДФС','7899877000'),('8527419630','2021-06-02','ДПІ У КОМУНАРСЬКОМУ РАЙОНІ М. ЗАПОРІЖЖЯ ГУ ДФС','8527419000'),('9874895123','2021-06-02','ДПІ У КОМУНАРСЬКОМУ РАЙОНІ М. ЗАПОРІЖЖЯ ГУ ДФС','9874895000');
/*!40000 ALTER TABLE `arch_taxpayer_certificate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `arch_transport_registration_certificate`
--

DROP TABLE IF EXISTS `arch_transport_registration_certificate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `arch_transport_registration_certificate` (
  `Registration_Id` char(8) NOT NULL,
  `Issue_Year` char(4) DEFAULT NULL,
  `Registration_Date` date DEFAULT NULL,
  `Passport_Id` char(9) DEFAULT NULL,
  `Validity_Date` date DEFAULT NULL,
  PRIMARY KEY (`Registration_Id`),
  KEY `Passport_Id` (`Passport_Id`),
  CONSTRAINT `arch_transport_registration_certificate_ibfk_1` FOREIGN KEY (`Passport_Id`) REFERENCES `arch_unified_passport_id` (`Passport_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arch_transport_registration_certificate`
--

LOCK TABLES `arch_transport_registration_certificate` WRITE;
/*!40000 ALTER TABLE `arch_transport_registration_certificate` DISABLE KEYS */;
/*!40000 ALTER TABLE `arch_transport_registration_certificate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `arch_unified_passport_id`
--

DROP TABLE IF EXISTS `arch_unified_passport_id`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `arch_unified_passport_id` (
  `Passport_Id` char(9) NOT NULL,
  PRIMARY KEY (`Passport_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arch_unified_passport_id`
--

LOCK TABLES `arch_unified_passport_id` WRITE;
/*!40000 ALTER TABLE `arch_unified_passport_id` DISABLE KEYS */;
INSERT INTO `arch_unified_passport_id` VALUES ('001122330'),('444582271'),('777369852'),('777698258'),('888223699'),('888696958');
/*!40000 ALTER TABLE `arch_unified_passport_id` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `birth_certificate`
--

DROP TABLE IF EXISTS `birth_certificate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `birth_certificate` (
  `Birth_Certificate_Id` char(9) NOT NULL,
  `Date_of_Birth` date DEFAULT NULL,
  `Passport_Id_Father` char(9) DEFAULT NULL,
  `Passport_Id_Mother` char(9) DEFAULT NULL,
  `Place_of_Birth` varchar(255) DEFAULT NULL,
  `Place_of_Registration` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Birth_Certificate_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `birth_certificate`
--

LOCK TABLES `birth_certificate` WRITE;
/*!40000 ALTER TABLE `birth_certificate` DISABLE KEYS */;
INSERT INTO `birth_certificate` VALUES ('000111000','1980-06-07','584693654','546546546','УКРАЇНА ЗАПОРІЗЬКА ОБЛАСТЬ ЗАПОРІЖЖЯ','Відділ реєстрації актів районого управління юстиції'),('000123320','2000-06-13','444589632','444582271','УКРАЇНА ЗАПОРІЗЬКА ОБЛАСТЬ ЗАПОРІЖЖЯ','Відділ реєстрації актів районого управління юстиції'),('444000173','2018-08-16','444589632','444582271','УКРАЇНА ЗАПОРІЗЬКА ОБЛАСТЬ ЗАПОРІЖЖЯ','Відділ реєстрації актів районого управління юстиції'),('444589000','1990-04-12','777698258','777369852','УКРАЇНА ЗАПОЛІЗЬКА ОБЛАСТЬ ЗАПОРІЖЖЯ','Відділ реєстрації актів районого управління юстиції'),('555000123','2002-08-14','555987789','555456654','УКРАЇНА ЗАПОРІЗЬКА ОБЛАСТЬ ЗАПОРІЖЖЯ','Відділ реєстрації актів районого управління юстиції'),('666000951','2001-08-14','666548953','666548952','УКРАЇНА ЗАПОРІЗЬКА ОБЛАСТЬ ЗАПОРІЖЖЯ','Відділ реєстрації актів районого управління юстиції');
/*!40000 ALTER TABLE `birth_certificate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `death_certificate`
--

DROP TABLE IF EXISTS `death_certificate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `death_certificate` (
  `Passport_Id` char(9) DEFAULT NULL,
  `Registration_Date` date DEFAULT NULL,
  `Registration_Place` varchar(255) DEFAULT NULL,
  `Agency` varchar(255) DEFAULT NULL,
  `Document_Id` char(9) NOT NULL,
  PRIMARY KEY (`Document_Id`),
  UNIQUE KEY `Passport_Id` (`Passport_Id`),
  CONSTRAINT `Passport_Id_fk` FOREIGN KEY (`Passport_Id`) REFERENCES `arch_unified_passport_id` (`Passport_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `death_certificate`
--

LOCK TABLES `death_certificate` WRITE;
/*!40000 ALTER TABLE `death_certificate` DISABLE KEYS */;
INSERT INTO `death_certificate` VALUES ('888223699','2021-06-04','Запорізький районий відділ реєстрації цивільного стану','Запорізький районий відділ реєстрації цивільного стану','12345678'),('888696958','2021-06-04','Запорізький районий відділ реєстрації цивільного стану','Запорізький районий відділ реєстрації цивільного стану','12365478'),('444582271','2021-06-13','Запорізький районий відділ реєстрації цивільного стану','Запорізький районий відділ реєстрації цивільного стану','444582000'),('777698258','2021-06-04','Запорізький районий відділ реєстрації цивільного стану','Запорізький районий відділ реєстрації цивільного стану','777691111'),('777369852','2021-06-04','Запорізький районий відділ реєстрації цивільного стану','Запорізький районий відділ реєстрації цивільного стану','78965412');
/*!40000 ALTER TABLE `death_certificate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marriage_certificate`
--

DROP TABLE IF EXISTS `marriage_certificate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `marriage_certificate` (
  `First_Passport_Id` char(9) DEFAULT NULL,
  `Second_Passport_Id` char(9) DEFAULT NULL,
  `Registration_Date` date DEFAULT NULL,
  `Act_Id` int NOT NULL,
  `First_Lastname_Before` varchar(30) DEFAULT NULL,
  `First_Lastname_After` varchar(30) DEFAULT NULL,
  `Second_Lastname_Before` varchar(30) DEFAULT NULL,
  `Second_Lastname_After` varchar(30) DEFAULT NULL,
  `Registration_Place` varchar(255) DEFAULT NULL,
  `Agency` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Act_Id`),
  UNIQUE KEY `First_Passport_Id` (`First_Passport_Id`,`Second_Passport_Id`),
  KEY `First_Passport_Id_i` (`First_Passport_Id`),
  KEY `Second_Passport_Id_i` (`Second_Passport_Id`),
  CONSTRAINT `marriage_certificate_ibfk_1` FOREIGN KEY (`First_Passport_Id`) REFERENCES `passport` (`Passport_Id`),
  CONSTRAINT `marriage_certificate_ibfk_2` FOREIGN KEY (`Second_Passport_Id`) REFERENCES `passport` (`Passport_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marriage_certificate`
--

LOCK TABLES `marriage_certificate` WRITE;
/*!40000 ALTER TABLE `marriage_certificate` DISABLE KEYS */;
INSERT INTO `marriage_certificate` VALUES ('555487123','000123321','2021-06-13',465,'Резніченко','Резніченко','Васильченко','Резніченко','Запорізький міський відділ реєстраціії актів цивільного стану','Запорізький міський відділ реєстраціії актів цивільного стану');
/*!40000 ALTER TABLE `marriage_certificate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `passport`
--

DROP TABLE IF EXISTS `passport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `passport` (
  `Passport_Id` char(9) NOT NULL,
  `First_Name` varchar(30) DEFAULT NULL,
  `Last_Name` varchar(30) DEFAULT NULL,
  `Patronymic` varchar(30) DEFAULT NULL,
  `Sex` char(1) DEFAULT NULL,
  `Date_of_Issue` date DEFAULT NULL,
  `Validity_Date` date DEFAULT NULL,
  `Agency_Id` char(4) DEFAULT NULL,
  `Taxpayer_Id` char(10) DEFAULT NULL,
  `Birth_Certificate_Id` char(9) DEFAULT NULL,
  `Record_Id` char(13) DEFAULT NULL,
  PRIMARY KEY (`Passport_Id`),
  UNIQUE KEY `Taxpayer_Id` (`Taxpayer_Id`,`Birth_Certificate_Id`,`Record_Id`),
  KEY `Birth_Certificate_Id_i` (`Birth_Certificate_Id`),
  KEY `Record_Id_i` (`Record_Id`),
  KEY `Taxpayer_Id_i` (`Taxpayer_Id`),
  CONSTRAINT `passport_ibfk_1` FOREIGN KEY (`Birth_Certificate_Id`) REFERENCES `birth_certificate` (`Birth_Certificate_Id`),
  CONSTRAINT `passport_ibfk_2` FOREIGN KEY (`Record_Id`) REFERENCES `reference_from_usr` (`Record_Id`),
  CONSTRAINT `passport_ibfk_3` FOREIGN KEY (`Taxpayer_Id`) REFERENCES `taxpayer_certificate` (`Taxpayer_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `passport`
--

LOCK TABLES `passport` WRITE;
/*!40000 ALTER TABLE `passport` DISABLE KEYS */;
INSERT INTO `passport` VALUES ('000111222','Михайло','Ковальов','Михайлович','Ч','2021-06-07','2031-06-07','1223','0001112220','000111000','1572489631532'),('000123321','Марія','Васильченко','Антоновна','Ж','2021-06-14','2031-06-14','1223','3213213210','000123320','0001233214521'),('444589173','Олег','Васильченко','Антонович','Ч',NULL,NULL,NULL,NULL,'444000173',NULL),('444589632','Антон','Васильченко','Антонович','Ч','2020-06-03','2030-06-03','1223','0014258655','444589000','1254745825880'),('555487123','Микита','Резніченко','Сергійович','Ч','2020-05-17','2030-05-17','1223','4862753951','555000123','9874123675351'),('666548951','Марія','Слюсаренко','Генадієвна','Ж','2019-05-17','2029-05-17','1223','3696399630','666000951','3693258874100');
/*!40000 ALTER TABLE `passport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `passport_data`
--

DROP TABLE IF EXISTS `passport_data`;
/*!50001 DROP VIEW IF EXISTS `passport_data`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `passport_data` AS SELECT 
 1 AS `Passport_Id`,
 1 AS `First_Name`,
 1 AS `Last_Name`,
 1 AS `Patronymic`,
 1 AS `Sex`,
 1 AS `Date_of_Issue`,
 1 AS `Validity_Date`,
 1 AS `Agency_Id`,
 1 AS `Taxpayer_Id`,
 1 AS `Birth_Certificate_Id`,
 1 AS `Record_Id`,
 1 AS `Date_of_Birth`,
 1 AS `Passport_Id_Father`,
 1 AS `Passport_Id_Mother`,
 1 AS `Place_of_Birth`,
 1 AS `Place_of_Registration`,
 1 AS `Reference_Id`,
 1 AS `Place_of_Registration_Live`,
 1 AS `Place_of_Issue`,
 1 AS `Registration_Date`,
 1 AS `Requested_Statements`,
 1 AS `First_Passport_Id`,
 1 AS `Second_Passport_Id`,
 1 AS `Act_Id`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `property_right_certificate`
--

DROP TABLE IF EXISTS `property_right_certificate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `property_right_certificate` (
  `Document_Id` char(9) NOT NULL,
  `Registration_Date` date DEFAULT NULL,
  `Agency` varchar(255) DEFAULT NULL,
  `Registrar_Passport_Id` char(9) DEFAULT NULL,
  `Ownership_Reason` varchar(255) DEFAULT NULL,
  `Issue_Reason` varchar(255) DEFAULT NULL,
  `Ownership_Form` char(1) DEFAULT NULL,
  `Share_Size` int DEFAULT NULL,
  `Owner_Passport_Id` char(9) DEFAULT NULL,
  `Property_Object` varchar(255) DEFAULT NULL,
  `Object_Id` int DEFAULT NULL,
  `Adress` varchar(255) DEFAULT NULL,
  `Cadastral_Id` char(19) DEFAULT NULL,
  `Object_Regestration_Date` date DEFAULT NULL,
  PRIMARY KEY (`Document_Id`),
  KEY `Owner_Passport_Id` (`Owner_Passport_Id`),
  CONSTRAINT `property_right_certificate_ibfk_1` FOREIGN KEY (`Owner_Passport_Id`) REFERENCES `passport` (`Passport_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `property_right_certificate`
--

LOCK TABLES `property_right_certificate` WRITE;
/*!40000 ALTER TABLE `property_right_certificate` DISABLE KEYS */;
INSERT INTO `property_right_certificate` VALUES ('012365478','2021-05-31','Агенство з купівлі-продажу нерухомого майна','000111222','Купівля об\'єкту','Оформлення акту купівлі-продажу','П',1,'444589632','Квартира',14525,'ЗАПОРІЗЬКА ОБЛАСТЬ ЗАПОРІЖЖЯ СИТОВА 113 12','4758219036001445555','2021-05-31'),('123215468','2021-06-13','Агенство з купівлі-продажу нерухомого майна','000111222','Купівля об\'\'єкту','Оформлення акту купівлі-продажу','П',1,'000123321','Квартира',1230,'ЗАПОРІЗЬКА ОБЛАСТЬ М. ЗАПОРІЖЖЯ ОЛІМПІЙСЬКА 16 1','8374651039485021987','2019-06-13');
/*!40000 ALTER TABLE `property_right_certificate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reference_from_usr`
--

DROP TABLE IF EXISTS `reference_from_usr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reference_from_usr` (
  `Record_Id` char(13) NOT NULL,
  `Reference_Id` char(14) DEFAULT NULL,
  `Place_of_Registration` varchar(255) DEFAULT NULL,
  `Place_of_Issue` varchar(255) DEFAULT NULL,
  `Registration_Date` date DEFAULT NULL,
  `Requested_Statements` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Record_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reference_from_usr`
--

LOCK TABLES `reference_from_usr` WRITE;
/*!40000 ALTER TABLE `reference_from_usr` DISABLE KEYS */;
INSERT INTO `reference_from_usr` VALUES ('0001233214521','00012332145210','ЗАПОРІЗЬКА ОБЛАСТЬ М. ЗАПОРІЖЖЯ ОЛІМПІЙСЬКА 16 1','Комунарський районий відділ у місті Запоріжжі Управління Державної міграційнї служби України в Запорізькій області','2021-06-13','Місце проживання'),('1254745825880','12547458258800','ЗАПОРІЗЬКА ОБЛАСТЬ М. ЗАПОРІЖЖЯ КОСМІЧНА 112 12','Комунарський районий відділ у місті Запоріжжі Управління Державної міграційної служби України в Запорізькій області','2021-06-02','Місце проживання'),('1572489631532','15724896315320','ЗАПОРІЗЬКА ОБЛАСТЬ М. ЗАПОРІЖЖЯ СОБОРНИЙ 106А 13','Комунарський районий відділ у місті Запоріжжі Управління Державної міграційної служби України в Запорізькій області','2021-06-07','Місце проживання'),('3693258874100','36932588741000','ЗАПОРІЗЬКА ОБЛАСТЬ М. ЗАПОРІЖЖЯ ЄВРОПЕЙСЬКА 11 30','Комунарський районий відділ у місті Запоріжжі Управління Державної міграційної служби України в Запорізькій області','2021-06-02','Місце проживання'),('5555698741230','55556987412300','ЗАПОРІЗЬКА ОБЛАСТЬ М. ЗАПОРІЖЖЯ КОСМІЧНА 112 12','Комунарський районий відділ у місті Запоріжжі Управління Державної міграційної служби України в Запорізькій області','2021-06-02','Мічце проживання'),('9874123675351','98741236753510','ЗАПОРІЗЬКА ОБЛАСТЬ М. ЗАПОРІЖЖЯ ЧУМАЧЕНКО 80 15','Комунарський районий відділ у місті Запоріжжі Управління Державної міграційної служби України в Запорізькій області','2021-06-02','Місце проживання');
/*!40000 ALTER TABLE `reference_from_usr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `taxpayer_certificate`
--

DROP TABLE IF EXISTS `taxpayer_certificate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `taxpayer_certificate` (
  `Taxpayer_Id` char(10) NOT NULL,
  `Registration_Date` date DEFAULT NULL,
  `Fiscal_Service_Agency` varchar(255) DEFAULT NULL,
  `Form_Id` char(10) DEFAULT NULL,
  PRIMARY KEY (`Taxpayer_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `taxpayer_certificate`
--

LOCK TABLES `taxpayer_certificate` WRITE;
/*!40000 ALTER TABLE `taxpayer_certificate` DISABLE KEYS */;
INSERT INTO `taxpayer_certificate` VALUES ('0001112220','2021-06-07','ДПІ У КОМУНАРСЬКОМУ РАЙОНІ М. ЗАПОРІЖЖЯ ГУ ДФС','0001011222'),('0014258655','2021-06-02','ДПІ У КОМУНАРСЬКОМУ РАЙОНІ М. ЗАПОРІЖЖЯ ГУ ДФС','0014258000'),('3211235284','2021-06-02','ДПІ У КОМУНАРСЬКОМУ РАЙОНІ М. ЗАПОРІЖЖЯ ГУ ДФС','3211235000'),('3213213210','2021-06-13','ДПІ У КОМУНАРСЬКОМУ РАЙОНІ М. ЗАПОРІЖЖЯ ГУ ДФС','3213213211'),('3696399630','2021-06-02','ДПІ У КОМУНАРСЬКОМУ РАЙОНІ М. ЗАПОРІЖЖЯ ГУ ДФС','3696399000'),('4862753951','2021-06-02','ДПІ У КОМУНАРСЬКОМУ РАЙОНІ М. ЗАПОРІЖЖЯ ГУ ДФС','4862753000');
/*!40000 ALTER TABLE `taxpayer_certificate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transport_registration_certificate`
--

DROP TABLE IF EXISTS `transport_registration_certificate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `transport_registration_certificate` (
  `Registration_Id` char(8) NOT NULL,
  `Issue_Year` char(4) DEFAULT NULL,
  `Registration_Date` date DEFAULT NULL,
  `Passport_Id` char(9) DEFAULT NULL,
  `Validity_Date` date DEFAULT NULL,
  PRIMARY KEY (`Registration_Id`),
  KEY `Passport_Id` (`Passport_Id`),
  CONSTRAINT `transport_registration_certificate_ibfk_1` FOREIGN KEY (`Passport_Id`) REFERENCES `passport` (`Passport_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transport_registration_certificate`
--

LOCK TABLES `transport_registration_certificate` WRITE;
/*!40000 ALTER TABLE `transport_registration_certificate` DISABLE KEYS */;
INSERT INTO `transport_registration_certificate` VALUES ('AP1232BB','2002','2021-05-31','555487123','2025-05-31'),('AP4309BB','2020','2021-05-31','444589632','2025-05-31'),('AP4329BB','2012','2021-05-31','444589632','2025-05-31'),('AP4859BB','2001','2021-05-31','444589632','2025-05-31');
/*!40000 ALTER TABLE `transport_registration_certificate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `User_Name` varchar(12) NOT NULL,
  `User_Password` varchar(32) DEFAULT NULL,
  `Passport_Id` char(9) DEFAULT NULL,
  `User_Permission` char(1) DEFAULT NULL,
  PRIMARY KEY (`User_Name`),
  KEY `Passport_Id_idx` (`Passport_Id`),
  CONSTRAINT `Passport_Id` FOREIGN KEY (`Passport_Id`) REFERENCES `passport` (`Passport_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('1234','12341234',NULL,'A'),('4321','43214321',NULL,'C'),('user1','11111111','444589632','S'),('user2','11111111','000123321','S');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'unified_state_register'
--

--
-- Dumping routines for database 'unified_state_register'
--
/*!50003 DROP FUNCTION IF EXISTS `count_of_property_certificates` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  FUNCTION `count_of_property_certificates`(passport_id char(9)) RETURNS int
    DETERMINISTIC
begin
    declare num int default 0;
	select count(*) into num 
		from property_right_certificate where  property_right_certificate.Owner_Passport_Id = passport_id;
	return num;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `count_of_transport_certificates` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE FUNCTION `count_of_transport_certificates`(passport_id char(9)) RETURNS int
    DETERMINISTIC
begin
    declare num int default 0;
	select count(*) into num 
		from transport_registration_certificate where  transport_registration_certificate.Passport_Id = passport_id;
	return num;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_birth_certificate_exists` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE FUNCTION `is_birth_certificate_exists`(birth_cert_id char(9)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare is_exists bool default false;
    declare num int default 0;
    
	select count(*) into num 
		from birth_certificate where birth_certificate.Birth_Certificate_Id = birth_cert_id;
	if num > 0
		then set is_exists = true;
	end if;
	return is_exists;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_marriage_certificate_exists` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  FUNCTION `is_marriage_certificate_exists`(passport_id char(9)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare is_exists bool default false;
    declare num int default 0;
    declare another_passport char(9) default null;
    select count(*) into num 
		from marriage_certificate where  marriage_certificate.First_Passport_Id = passport_id or marriage_certificate.Second_Passport_Id = passport_id;
	if num > 0 then
		set is_exists = true;
	end if;
	return is_exists;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_passport_exists` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE FUNCTION `is_passport_exists`(passport_id varchar(9)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare existance bool default false;
	declare num int default 0;
	select count(*) into num from passport where passport_id = passport.Passport_Id;
	if num > 0 
		then set existance = true;
	end if;
	return existance;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_passport_has_birth_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  FUNCTION `is_passport_has_birth_certificate`(passport_id char(9), birth_cert_id char(9)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare is_has bool default false;
    declare birth_cert_id_field char(9) default null;
    
	select passport.Birth_Certificate_Id into birth_cert_id_field 
		from passport where passport.Passport_Id = passport_id;
	if birth_cert_id_field = birth_cert_id
		then set is_has = true;
	end if;
	return is_has;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_passport_has_reference_from_usr` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE FUNCTION `is_passport_has_reference_from_usr`(passport_id char(9), record_id char(13)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare exception condition for sqlstate '45000';
	declare is_has bool default false;
    declare reference_field char(13) default null;
	select passport.Record_Id into reference_field 
		from passport where passport.Passport_Id = passport_id;
	if reference_field = record_id
		then set is_has = true;
	end if;
	return is_has;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_passport_has_taxpayer_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE FUNCTION `is_passport_has_taxpayer_id`(passport_id char(9), taxpayer char(10)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare is_has bool default false;
    declare taxpayer_id_field char(10) default null;
    
	select passport.Taxpayer_Id into taxpayer_id_field 
		from passport where passport.Passport_Id = passport_id;
	if taxpayer_id_field = taxpayer
		then set is_has = true;
	end if;
	return is_has;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_passport_issued` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  FUNCTION `is_passport_issued`(passport_id char(9)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare exception condition for sqlstate '45000';
	declare is_issued bool default false;
	declare date_of_issue date default null;
	declare validity_date date default null;
	declare agency_id char(4) default null;
    if not is_passport_exists(passport_id)
		then signal exception set message_text = "Не вірний номер паспорту";
    end if;
	select passport.Date_of_Issue, passport.Validity_Date, passport.Agency_Id into date_of_issue, validity_date, agency_id
    from passport where passport.Passport_Id = passport_id;
	if date_of_issue = null or validity_date = null or agency_id = null
		then set is_issued = false;
	else 
		set is_issued = true;
	end if;
	return is_issued;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_password_correct` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE FUNCTION `is_password_correct`(username varchar(12), user_password varchar(32)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare existance bool default false;
	declare num int default 0;
	select count(users.User_Name) into num from users where username = users.User_Name and user_password = users.User_Password;
	if num > 0 
		then set existance = true;
	end if;
	return existance;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_reference_from_usr_already_archivated` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  FUNCTION `is_reference_from_usr_already_archivated`(record char(13)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare exception condition for sqlstate '45000';
	declare is_archivated bool  default false;
    declare num int default 0;
    
	select count(*) into num 
		from arch_reference_from_usr where arch_reference_from_usr.Record_Id = record;
	if num > 0
		then set is_archivated = true;
	end if;
	return is_archivated;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_reference_from_usr_exists` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  FUNCTION `is_reference_from_usr_exists`(record char(13)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare exception condition for sqlstate '45000';
	declare is_exists bool default false;
    declare num int default 0;
    
	select count(*) into num 
		from reference_from_usr where reference_from_usr.Record_Id = record;
	if num > 0
		then set is_exists = true;
	end if;
	return is_exists;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_taxpayer_certificate_exists` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  FUNCTION `is_taxpayer_certificate_exists`(taxpayer_id char(10)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare is_exists bool default false;
    declare num int default 0;
    
	select count(*) into num 
		from taxpayer_certificate where taxpayer_certificate.Taxpayer_Id = taxpayer_id;
	if num > 0
		then set is_exists = true;
	end if;
	return is_exists;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_username_exists` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  FUNCTION `is_username_exists`(username varchar(12)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare existance bool default false;
	declare num int default 0;
	select count(users.User_Name) into num from users where username = users.User_Name;
	if num > 0 
		then set existance = true;
	end if;
	return existance;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_user_passport_exists` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE FUNCTION `is_user_passport_exists`(passport varchar(9)) RETURNS tinyint(1)
    DETERMINISTIC
begin
	declare existance bool default false;
	declare num int default 0;
	select count(users.Passport_Id) into num from users where passport = users.Passport_Id;
	if num > 0 
		then set existance = true;
	end if;
	return existance;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `archivate_birth_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `archivate_birth_certificate`(in birth_cert_id char(9))
begin
	set foreign_key_checks=0;
	insert into arch_birth_certificate (Birth_Certificate_Id, Date_of_Birth, Passport_Id_Father, Passport_Id_Mother, Place_of_Birth, Place_of_Registration)
		select * from birth_certificate where birth_certificate.Birth_Certificate_Id = birth_cert_id;
	delete from birth_certificate where birth_certificate.Birth_Certificate_Id = birth_cert_id;
	set foreign_key_checks=1;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `archivate_marriage` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `archivate_marriage`(in passport char(9))
arch_marriage:
begin
	declare act int default null;
    if not is_marriage_certificate_exists(passport)
		then leave arch_marriage;
	end if;
    select marriage_certificate.Act_Id into act from marriage_certificate where marriage_certificate.First_Passport_Id = passport or marriage_certificate.Second_Passport_Id = passport;
    set foreign_key_checks=0;
	insert into arch_marriage_certificate (First_Passport_Id, Second_Passport_Id, Registration_Date, Act_Id, First_Lastname_Before, First_Lastname_After, Second_Lastname_Before, Second_Lastname_After, Registration_Place, Agency)
		select * from marriage_certificate where marriage_certificate.First_Passport_Id = passport or marriage_certificate.Second_Passport_Id = passport;
	update arch_marriage_certificate set arch_marriage_certificate.Arch_Date = curdate() where arch_marriage_certificate.Act_Id = act;
    delete from marriage_certificate where marriage_certificate.First_Passport_Id = passport or marriage_certificate.Second_Passport_Id = passport;
    set foreign_key_checks=1;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `archivate_passport` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `archivate_passport`(in passport_id char(9))
begin
	declare exception condition for sqlstate '45000';
    declare last_record bigint default null;
    declare record_from_passport char(13) default null;
	if not is_passport_exists(passport_id)
		then signal exception set message_text = "Невірний номер паспорту";
    end if;
    select passport.Record_Id into record_from_passport from passport where passport.Passport_Id = passport_id;
    select arch_reference_from_usr.Arch_Doc_Id into last_record from arch_reference_from_usr where arch_reference_from_usr.Record_Id = record_from_passport;
    SET FOREIGN_KEY_CHECKS=0;
	insert into arch_passport(Passport_Id, First_Name, Last_Name, Patronymic, Sex, Date_of_Issue, Validity_Date, Agency_Id, Taxpayer_Id, Birth_Certificate_Id) 
		select Passport_Id, First_Name, Last_Name, Patronymic, Sex, Date_of_Issue, Validity_Date, Agency_Id, Taxpayer_Id, Birth_Certificate_Id from passport where passport.Passport_Id = passport_id;
	update arch_passport set arch_passport.Record_Id = last_record, arch_passport.Arch_Date = curdate() where arch_passport.Arch_Doc_Id = last_insert_id();
	delete from passport where passport.Passport_Id = passport_id;
    SET FOREIGN_KEY_CHECKS=1;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `archivate_property_right_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `archivate_property_right_certificate`(in passport char(9))
arch_property:
begin
	if count_of_property_certificates(passport) = 0
		then leave arch_property;
	end if;
    set foreign_key_checks=0;
	insert into arch_property_right_certificate (Document_Id, Registration_Date, Agency, Registrar_Passport_Id, Ownership_Reason, Issue_Reason, Ownership_Form, Share_Size, Owner_Passport_Id, Property_Object, Object_Id, Adress, Cadastral_Id, Object_Regestration_Date)
		select * from property_right_certificate where property_right_certificate.Owner_Passport_Id = passport;
	update arch_property_right_certificate set arch_property_right_certificate.Arch_Date = curdate() where arch_property_right_certificate.Owner_Passport_Id = passport;
	delete from property_right_certificate where property_right_certificate.Owner_Passport_Id = passport;
    set foreign_key_checks=1;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `archivate_reference_from_usr` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `archivate_reference_from_usr`(in record_id char(13))
begin
	declare exception condition for sqlstate '45000';

    if is_reference_from_usr_exists(record_id)  then
		set foreign_key_checks=0;
        insert into arch_reference_from_usr (Record_Id, Reference_Id, Place_of_Registration, Place_of_Issue, Registration_Date, Requested_Statements)
			select reference_from_usr.Record_Id, reference_from_usr.Reference_Id, reference_from_usr.Place_of_Registration, reference_from_usr.Place_of_Issue, reference_from_usr.Registration_Date, reference_from_usr.Requested_Statements 
				from reference_from_usr where reference_from_usr.Record_Id = record_id;
            update arch_reference_from_usr set arch_reference_from_usr.Arch_Date = curdate() where arch_reference_from_usr.Arch_Doc_Id = last_insert_id();
		delete from reference_from_usr where reference_from_usr.Record_Id = record_id;
		set foreign_key_checks=1;
    else 
		signal exception set message_text = "Такого витягу з ЄДР не існує";
	end if;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `archivate_taxpayer_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `archivate_taxpayer_certificate`(in taxpayer_id char(10))
begin
	set foreign_key_checks=0;
	insert into arch_taxpayer_certificate(Taxpayer_Id, Registration_Date, Fiscal_Service_Agency, Form_Id)
		select taxpayer_certificate.Taxpayer_Id, taxpayer_certificate.Registration_Date, taxpayer_certificate.Fiscal_Service_Agency, taxpayer_certificate.Form_Id 
			from taxpayer_certificate where taxpayer_certificate.Taxpayer_Id = taxpayer_id;
	delete from taxpayer_certificate where taxpayer_certificate.Taxpayer_Id = taxpayer_id;
    set foreign_key_checks=1;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `archivate_transport_registration_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `archivate_transport_registration_certificate`(in passport char(9))
arch_car:
begin
	if count_of_transport_certificates(passport) = 0
		then leave arch_car;
	end if;
    set foreign_key_checks=0;
	insert into arch_transport_registration_certificate
		select * from transport_registration_certificate where transport_registration_certificate.Passport_Id = passport;
	delete from transport_registration_certificate where transport_registration_certificate.Passport_Id = passport;
    set foreign_key_checks=1;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `find_car_by_registration_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `find_car_by_registration_id`(in reg_id char(8))
begin
    select * from transport_registration_certificate where transport_registration_certificate.Registration_Id like concat ("%", reg_id, "%")
    order by Registration_Date;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `find_children_by_dead_parent` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `find_children_by_dead_parent`(in doc_id char(9))
begin
	declare passport char(9) default null;
    select death_certificate.Passport_Id into passport from death_certificate where death_certificate.Document_Id = doc_id;
    select passport_data.Passport_Id, passport_data.First_Name, passport_data.Last_Name, passport_data.Patronymic, passport_data.Sex, 
		   passport_data.Birth_Certificate_Id, passport_data.Date_of_Birth, passport_data.Passport_Id_Father, passport_data.Passport_Id_Mother, passport_data.Place_of_Birth, passport_data.Place_of_Registration 
		from passport_data where passport_data.Passport_Id_Father = passport or passport_data.Passport_Id_Mother = passport
    order by passport_data.Date_of_Birth;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `find_passport_data` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `find_passport_data`(in passport char(9), in tax char(10), in ref char(13), in first_name varchar(30), in last_name varchar(30), in patronimic varchar(30), in place varchar(255))
begin
	select * from passport_data where (passport_data.Passport_Id like concat("%", passport, "%")
								and passport_data.First_Name like  concat("%", first_name, "%")
                                and passport_data.Last_Name like concat("%", last_name, "%")
                                and passport_data.Patronymic like concat("%", patronimic, "%"))
                                and ((passport_data.Taxpayer_Id like  concat("%", tax, "%")) or (tax = "%" and passport_data.Taxpayer_Id is null))
                                and ((passport_data.Record_Id like  concat("%", ref, "%")) or (ref = "%" and  passport_data.Record_Id is null))
                                and ((passport_data.Place_of_Registration_Live like concat("%", place, "%")) or (place = "%%%%%" and passport_data.Place_of_Registration_Live is null));
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `find_property_by_owner_passport_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `find_property_by_owner_passport_id`(in passport char(9))
begin
    select * from property_right_certificate where property_right_certificate.Owner_Passport_Id like concat("%", passport, "%")
    order by Registration_Date;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_birth_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `get_birth_certificate`(in passport char(9))
begin
	declare passport_father char(9) default null;
    declare passport_mother char(9) default null;
    declare father_name varchar(92) default null;
    declare mother_name varchar(92) default null;
	select birth_certificate.Passport_Id_Father, birth_certificate.Passport_Id_Mother into passport_father, passport_mother 
		from passport inner join birth_certificate on passport.Birth_Certificate_Id = birth_certificate.Birth_Certificate_Id
        where passport.Passport_Id = passport;
	if is_passport_exists(passport_father)
		then select concat(passport.Last_Name," ", passport.First_Name," ", passport.Patronymic) into father_name from passport where passport.Passport_Id = passport_father;
	else select concat(arch_passport.Last_Name," ", arch_passport.First_Name," ", arch_passport.Patronymic) into father_name 
			from arch_passport 
            where arch_passport.Passport_Id = passport_father and arch_passport.Arch_Doc_Id = (select max(arch_passport.Arch_Doc_Id) from arch_passport where arch_passport.Passport_Id = passport_father);
	end  if;
    if is_passport_exists(passport_mother)
		then select concat(passport.Last_Name," ", passport.First_Name," ", passport.Patronymic) into mother_name from passport where passport.Passport_Id = passport_mother;
	else select concat(arch_passport.Last_Name," ", arch_passport.First_Name," ", arch_passport.Patronymic) into mother_name 
			from arch_passport 
            where arch_passport.Passport_Id = passport_mother and arch_passport.Arch_Doc_Id = (select max(arch_passport.Arch_Doc_Id) from arch_passport where arch_passport.Passport_Id = passport_mother);
	end if;
	select concat(passport.Last_Name," ", passport.First_Name," ", passport.Patronymic), 
		   birth_certificate.Birth_Certificate_Id, birth_certificate.Date_of_Birth, birth_certificate.Place_of_Birth, birth_certificate.Place_of_Registration, 
           (father_name), (mother_name)
		from passport inner join birth_certificate on passport.Birth_Certificate_Id = birth_certificate.Birth_Certificate_Id
        where passport.Passport_Id = passport;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_marriage_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `get_marriage_certificate`(in passport char(9))
begin
	declare exception condition for sqlstate '45000';
	declare first_passport char(9) default null;
    declare second_passport char(9) default null;
	select passport_data.First_Passport_Id, passport_data.Second_Passport_Id into  first_passport, second_passport
		from passport_data
        where passport_data.Passport_Id = passport;
	if first_passport = null or second_passport = null
		then signal exception set message_text = "Не перебуває у шлюбі";
	end if;
    select marriage_certificate.Registration_Date, marriage_certificate.Act_Id, marriage_certificate.First_Lastname_Before, marriage_certificate.First_Lastname_After, marriage_certificate.Second_Lastname_Before, marriage_certificate.Second_Lastname_After, marriage_certificate.Registration_Place, marriage_certificate.Agency,
		   (select concat(passport_data.Last_Name," ", passport_data.First_Name," ", passport_data.Patronymic) from passport_data where passport_data.Passport_Id = first_passport),
           (select concat(passport_data.Last_Name," ", passport_data.First_Name," ", passport_data.Patronymic) from passport_data where passport_data.Passport_Id = second_passport),
           (select passport_data.Date_of_Birth from passport_data where passport_data.Passport_Id = first_passport),
           (select passport_data.Date_of_Birth from passport_data where passport_data.Passport_Id = second_passport)
        from marriage_certificate
		where marriage_certificate.First_Passport_Id = first_passport and marriage_certificate.Second_Passport_Id = second_passport;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_passport` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `get_passport`(in passport char(9))
begin
	select Passport_Id, First_Name, Last_Name, Patronymic, Sex, Date_of_Issue, Validity_Date, Agency_Id, Taxpayer_Id, Record_Id, Date_of_Birth, Place_of_Birth
		from passport_data where passport_data.Passport_Id = passport;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_property_ownership_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `get_property_ownership_certificate`(in passport char(9))
begin
	declare exception condition for sqlstate '45000';
    declare registrar_passport char(9) default null;
    if count_of_property_certificates(passport) = 0
		then signal exception set message_text = "Жодного свідоцтва реєстрації нерухомого майна не знайдено";
	end if;
	select property_right_certificate.Registrar_Passport_Id into registrar_passport from property_right_certificate where property_right_certificate.Owner_Passport_Id = passport;
    select property_right_certificate.Document_Id, property_right_certificate.Registration_Date, property_right_certificate.Agency, property_right_certificate.Ownership_Reason, property_right_certificate.Issue_Reason, property_right_certificate.Ownership_Form, property_right_certificate.Share_Size, property_right_certificate.Property_Object, property_right_certificate.Object_Id, property_right_certificate.Adress, property_right_certificate.Cadastral_Id, property_right_certificate.Object_Regestration_Date,
        (select concat(passport_data.Last_Name, " ", passport_data.First_Name, " ", passport_data.Patronymic) from passport_data where passport_data.Passport_Id = registrar_passport),
        (select concat(passport_data.Last_Name, " ", passport_data.First_Name, " ", passport_data.Patronymic) from passport_data where passport_data.Passport_Id = passport),
        (select passport_data.Taxpayer_Id from passport_data where passport_data.Passport_Id = passport)
        from property_right_certificate
		where property_right_certificate.Owner_Passport_Id = passport;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_reference_from_usr` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `get_reference_from_usr`(in passport char(9))
begin
	select concat(passport.Last_Name," ", passport.First_Name," ", passport.Patronymic, " "), 
		   birth_certificate.Date_of_Birth, birth_certificate.Place_of_Birth,
           reference_from_usr.Record_Id, reference_from_usr.Reference_Id, reference_from_usr.Place_of_Registration, reference_from_usr.Place_of_Issue, reference_from_usr.Registration_Date, reference_from_usr.Requested_Statements
		from passport inner join birth_certificate on passport.Birth_Certificate_Id = birth_certificate.Birth_Certificate_Id inner join reference_from_usr on passport.Record_Id = reference_from_usr.Record_Id
        where passport.Passport_Id = passport;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_taxpayer_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `get_taxpayer_certificate`(in passport char(9))
begin
	select concat(passport.Last_Name," ", passport.First_Name," ", passport.Patronymic), 
		   birth_certificate.Date_of_Birth, 
           taxpayer_certificate.Taxpayer_Id, taxpayer_certificate.Registration_Date, taxpayer_certificate.Fiscal_Service_Agency, taxpayer_certificate.Form_Id
		from passport inner join birth_certificate on passport.Birth_Certificate_Id = birth_certificate.Birth_Certificate_Id inner join taxpayer_certificate on passport.Taxpayer_Id = taxpayer_certificate.Taxpayer_Id
        where passport.Passport_Id = passport;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_transport_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `get_transport_certificate`(in passport char(9))
begin
	declare exception condition for sqlstate '45000';
    if count_of_transport_certificates(passport) = 0
		then signal exception set message_text = "Жодного свідоцтва реєстрації транспорту не знайдено";
	end if;

    select transport_registration_certificate.Registration_Id, transport_registration_certificate.Issue_Year, transport_registration_certificate.Registration_Date, transport_registration_certificate.Validity_Date,
		   (select concat(passport_data.Last_Name," ", passport_data.First_Name," ", passport_data.Patronymic) from passport_data where passport_data.Passport_Id = passport),
           (select passport_data.Place_of_Registration_Live from passport_data where passport_data.Passport_Id = passport)
        from transport_registration_certificate
		where transport_registration_certificate.Passport_Id = passport;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `record_birth` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `record_birth`(in passport_id char(9), in first_name varchar(30), in last_name varchar(30), in patronimic varchar(30), in sex char(1), birth_cert_id char(9),
in date_of_birth date, in passport_f char(9), in passport_m char(9), in place_of_birth varchar(255), in place_of_reg varchar(255))
begin
	declare exception condition for sqlstate '45000';
	if is_passport_exists(passport_id)
		then signal exception set message_text = "Цей номер паспорту вже зайнято";
    end if;
    if is_birth_certificate_exists(birth_cert_id)
		then signal exception set message_text = "Цей номер свідоцтва про народження вже зареєстровано";
	end if;
	insert into birth_certificate (Birth_Certificate_Id, Date_of_Birth, Passport_Id_Father, Passport_Id_Mother, Place_of_Birth, Place_of_Registration)
		values (birth_cert_id, date_of_birth, passport_f, passport_m, place_of_birth, place_of_reg);
	insert into passport (Passport_Id, First_Name, Last_Name, Patronymic, Sex, Birth_Certificate_Id)
		values (passport_id, first_name, last_name, patronimic, sex, birth_cert_id);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `record_death` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `record_death`(in passport_id char(9), in document_id char(9), in reg_place varchar(255), in agency varchar(255))
begin
	declare exception condition for sqlstate '45000';
    declare birth_cert_id char(9) default null;
    declare tax_cert_id char(10) default null;
    declare recod_id char(13) default null;
	if not is_passport_exists(passport_id)
		then signal exception set message_text = "Невірний номер паспорту";
	end if;
    select passport.Birth_Certificate_Id into birth_cert_id from passport where passport.Passport_Id = passport_id;
    select passport.Taxpayer_Id into tax_cert_id from passport where passport.Passport_Id = passport_id;
    select passport.Record_Id into recod_id from passport where passport.Passport_Id = passport_id;
    call archivate_birth_certificate(birth_cert_id);
	call archivate_taxpayer_certificate(tax_cert_id);
	call archivate_reference_from_usr(recod_id);
    call archivate_marriage(passport_id);
    call archivate_transport_registration_certificate(passport_id);
    call archivate_property_right_certificate(passport_id);
    
    call archivate_passport(passport_id);
    set foreign_key_checks=0;
    insert into death_certificate 
		values (passport_id, curdate(), reg_place, agency, document_id);
	insert into arch_unified_passport_id(Passport_Id)
    
		values(passport_id);
	set foreign_key_checks=1;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `record_marriage` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `record_marriage`(in passport_h char(9), in passport_w char(9), in reg_place varchar(255), in agency varchar(255), in act_id int)
begin
	declare exception condition for sqlstate '45000';
    declare husband_last_name varchar(30) default null;
    declare wife_last_name varchar(30) default null;
	if not is_passport_exists(passport_h) or not is_passport_exists(passport_w)
		then signal exception set message_text = "Невірний номер паспорту";
	end if;
    select passport.Last_Name into husband_last_name from passport where passport.Passport_Id = passport_h;
    select passport.Last_Name into wife_last_name from passport where passport.Passport_Id = passport_w;
	insert into marriage_certificate (First_Passport_Id, Second_Passport_Id, Registration_Date, Act_Id, First_Lastname_Before, First_Lastname_After, Second_Lastname_Before, Second_Lastname_After, Registration_Place, Agency)
		values (passport_h, passport_w, curdate(), act_id, husband_last_name, husband_last_name, wife_last_name, husband_last_name, reg_place, agency);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `record_passport` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `record_passport`(in passport_id char(9), in first_name varchar(30), in last_name varchar(30), in patronimic varchar(30), in sex char(1), 
								 in date_of_issue date, in agency_id char(4), in taxpayer_id char(10), in birth_cert_id char(9), in record_id char(13))
begin
	declare exception condition for sqlstate '45000';
    declare validity_date date default null; 
    declare birth_date date default null;
	if not is_passport_exists(passport_id)
		then signal exception set message_text = "Невірний номер паспорту";
    end if;
    if not is_taxpayer_certificate_exists(taxpayer_id)
		then signal exception set message_text = "КПП з таким номером не існує";
	end if;
    if not is_reference_from_usr_exists(record_id)
		then signal exception set message_text = "Виятгу з ЄДР не існує";
    end if;
	if not is_birth_certificate_exists(birth_cert_id)
		then signal exception set message_text = "Цього свідоцтва про народження не існує";
    end if;
    if not is_passport_has_taxpayer_id(passport_id, taxpayer_id)
		then signal exception set message_text = "Цей пасспорт не має КПП, або має інше";
    end if;
    if not is_passport_has_reference_from_usr(passport_id, record_id)
		then signal exception set message_text = "Цей пасспорт не має витягу або має інший";
    end if;
    if not is_passport_has_birth_certificate(passport_id, birth_cert_id)
		then signal exception set message_text = "Цей паспорт не має свідоцтва про народження або має інше";
    end if;
    call archivate_passport(passport_id);
    select Date_of_Birth into birth_date from birth_certificate where birth_certificate.Birth_Certificate_Id = birth_cert_id;
    if  year(date_of_issue) - year(birth_date) < 17
		then set validity_date = date_add(date_of_issue, interval 4 year);
	else 
		set validity_date = date_add(date_of_issue, interval 10 year);
    end if;
	insert into passport(Passport_Id, First_Name, Last_Name, Patronymic, Sex, Date_of_Issue, Validity_Date, Agency_Id, Taxpayer_Id, Birth_Certificate_Id, Record_Id)
		values (passport_id, first_name, last_name, patronimic, sex, date_of_issue, validity_date, agency_id, taxpayer_id, birth_cert_id, record_id);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `record_property_right_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `record_property_right_certificate`(in document_id char(9), in agency varchar(255), in registrar_passport_id char(9), in ownership_reason varchar(255), in issue_reason varchar(255), 
														   in ownership_form char(1), in share_size int, in passport_id char(9), in property_object varchar(255), in object_id int, in adress varchar(255), 
                                                           in cadastral_id char(19), in object_reg_date date)
begin
	declare exception condition for sqlstate '45000';
	if not is_passport_exists(passport_id)
		then signal exception set message_text = "Невірний номер паспорту";
	end if;
	insert into property_right_certificate 
		values (document_id, curdate(), agency, registrar_passport_id, ownership_reason, issue_reason, ownership_form, share_size, passport_id, property_object, object_id, adress, cadastral_id, object_reg_date);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `record_reference_from_usr` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `record_reference_from_usr`(in passport char(9), in record char(13), in reference_id char(14), in place_of_reg varchar(255), in place_of_issue varchar(255), in requested_statements varchar(255))
begin
	declare exception condition for sqlstate '45000';
	if not is_passport_exists(passport)
		then signal exception set message_text = "Невірний номер паспорту";
    end if;
    if is_reference_from_usr_exists(record)
		then call archivate_reference_from_usr(record);
	end if;
    insert into reference_from_usr (Record_Id, Reference_Id, Place_of_Issue, Registration_Date, Requested_Statements, Place_of_Registration)
		values (record, reference_id, place_of_issue, curdate(), requested_statements, place_of_reg);
    if is_passport_has_reference_from_usr(passport, record)
		then call archivate_reference_from_usr(record);
	end if;
    SET FOREIGN_KEY_CHECKS=0;
	update passport 
			set Record_Id = record where Passport_Id = passport;
	SET FOREIGN_KEY_CHECKS=1;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `record_taxpayer_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `record_taxpayer_certificate`(in passport_id char(9), in taxpayer_id char(10), in fiscal_service_agency varchar(255), in form_id char(10))
begin
	declare exception condition for sqlstate '45000';
	if not is_passport_exists(passport_id)
		then signal exception set message_text = "Невірний номер паспорту";
    end if;
    if is_taxpayer_certificate_exists(taxpayer_id)
		then signal exception set message_text = "КПП з таким номером вже існує";
	end if;
    if is_passport_has_taxpayer_id(passport_id, taxpayer_id)
		then signal exception set message_text = "Цей пасспорт вже має КПП";
    end if;
	insert into taxpayer_certificate (Taxpayer_Id, Registration_Date, Fiscal_Service_Agency, Form_Id)
		values (taxpayer_id, curdate(), fiscal_service_agency, form_id);
	update passport 
		set passport.Taxpayer_Id = taxpayer_id where passport.Passport_Id = passport_id;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `record_transport_registration_certificate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `record_transport_registration_certificate`(in reg_id char(8), in issue_year char(4), in passport_id char(9))
begin
	declare exception condition for sqlstate '45000';
	if not is_passport_exists(passport_id)
		then signal exception set message_text = "Невірний номер паспорту";
	end if;
	insert into transport_registration_certificate (Registration_Id, Issue_Year, Registration_Date, Passport_Id, Validity_Date)
		values (reg_id, issue_year, curdate(), passport_id, date_add(curdate(), interval 10 year));
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sign_in_user` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE PROCEDURE `sign_in_user`(in username varchar(12), in user_password varchar(32), out permission char(1), out passport_id char(9))
begin
	declare existance bool;
	declare exception condition for sqlstate '45000';
	set existance = is_username_exists(username);
	if not existance 
		then signal exception set message_text = "Невірне ім'я користувача";
	end if;
	set existance = is_password_correct(username, user_password);
	if not existance 
		then signal exception set message_text = "Не вірний пароль";
	end if;
	select users.User_Permission into permission from users where user_password = users.User_Password and username = users.User_Name;
    select users.Passport_Id into passport_id from users where user_password = users.User_Password and username = users.User_Name; 
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sign_up_user` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE  PROCEDURE `sign_up_user`(in username varchar(12), in user_password varchar(32), in permission char(1), in passport_id char(9))
begin
    declare exception condition for sqlstate '45000';
    if is_username_exists(username)
		then signal exception set message_text = "Ім'я користувача вже зайнято";
	end if;
    if is_user_passport_exists(passport_id)
		then signal exception set message_text = "На цей номер паспорту вже зареєстровано користувача";
	end if;
    if not is_passport_exists(passport_id)
		then signal exception set message_text = "Не вірний номер паспорту";
	end if;
	insert into users (User_Name, User_Password, User_Permission, Passport_Id)
		values (username, user_password, permission, passport_id);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `passport_data`
--

/*!50001 DROP VIEW IF EXISTS `passport_data`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
--  /*!50013 DEFINER=`root`@`%` SQL SECURITY DEFINER */
/*!50001 CREATE VIEW `passport_data` (`Passport_Id`,`First_Name`,`Last_Name`,`Patronymic`,`Sex`,`Date_of_Issue`,`Validity_Date`,`Agency_Id`,`Taxpayer_Id`,`Birth_Certificate_Id`,`Record_Id`,`Date_of_Birth`,`Passport_Id_Father`,`Passport_Id_Mother`,`Place_of_Birth`,`Place_of_Registration`,`Reference_Id`,`Place_of_Registration_Live`,`Place_of_Issue`,`Registration_Date`,`Requested_Statements`,`First_Passport_Id`,`Second_Passport_Id`,`Act_Id`) 
AS select `passport`.`Passport_Id` AS `Passport_Id`,`passport`.`First_Name` AS `First_Name`,`passport`.`Last_Name` AS `Last_Name`,`passport`.`Patronymic` AS `Patronymic`,`passport`.`Sex` AS `Sex`,`passport`.`Date_of_Issue` AS `Date_of_Issue`,`passport`.`Validity_Date` AS `Validity_Date`,`passport`.`Agency_Id` AS `Agency_Id`,`passport`.`Taxpayer_Id` AS `Taxpayer_Id`,`passport`.`Birth_Certificate_Id` AS `Birth_Certificate_Id`,`passport`.`Record_Id` AS `Record_Id`,`birth_certificate`.`Date_of_Birth` AS `Date_of_Birth`,`birth_certificate`.`Passport_Id_Father` AS `Passport_Id_Father`,`birth_certificate`.`Passport_Id_Mother` AS `Passport_Id_Mother`,`birth_certificate`.`Place_of_Birth` AS `Place_of_Birth`,`birth_certificate`.`Place_of_Registration` AS `Place_of_Registration`,`reference_from_usr`.`Reference_Id` AS `Reference_Id`,`reference_from_usr`.`Place_of_Registration` AS `Place_of_Registration`,`reference_from_usr`.`Place_of_Issue` AS `Place_of_Issue`,`reference_from_usr`.`Registration_Date` AS `Registration_Date`,`reference_from_usr`.`Requested_Statements` AS `Requested_Statements`,`marriage_certificate`.`First_Passport_Id` AS `First_Passport_Id`,`marriage_certificate`.`Second_Passport_Id` AS `Second_Passport_Id`,`marriage_certificate`.`Act_Id` AS `Act_Id` from (((`passport` left join `birth_certificate` on((`passport`.`Birth_Certificate_Id` = `birth_certificate`.`Birth_Certificate_Id`))) left join `reference_from_usr` on((`passport`.`Record_Id` = `reference_from_usr`.`Record_Id`))) left join `marriage_certificate` on(((`passport`.`Passport_Id` = `marriage_certificate`.`First_Passport_Id`) or (`passport`.`Passport_Id` = `marriage_certificate`.`Second_Passport_Id`)))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-14  0:52:31
