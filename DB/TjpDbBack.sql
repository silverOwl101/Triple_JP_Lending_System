CREATE DATABASE  IF NOT EXISTS `tjpdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `tjpdb`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: tjpdb
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `administrator`
--

DROP TABLE IF EXISTS `administrator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administrator` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`uid`),
  KEY `idx_admin` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='	';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrator`
--

LOCK TABLES `administrator` WRITE;
/*!40000 ALTER TABLE `administrator` DISABLE KEYS */;
INSERT INTO `administrator` VALUES ('bd0b8d6f-1ab6-423d-abd7-cd5fcde9170a','22342','admin','admin');
/*!40000 ALTER TABLE `administrator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `collection`
--

DROP TABLE IF EXISTS `collection`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `collection` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) NOT NULL,
  `customer_uid` char(36) NOT NULL,
  `loan_information_uid` char(36) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`uid`),
  KEY `colIndex` (`uid`),
  KEY `fk_customer_id_idx` (`customer_uid`),
  KEY `fk_loan_information_id_idx` (`loan_information_uid`),
  CONSTRAINT `fk_customer_id` FOREIGN KEY (`customer_uid`) REFERENCES `customer_account` (`uid`),
  CONSTRAINT `fk_loan_information_id` FOREIGN KEY (`loan_information_uid`) REFERENCES `loan_information` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `collection`
--

LOCK TABLES `collection` WRITE;
/*!40000 ALTER TABLE `collection` DISABLE KEYS */;
INSERT INTO `collection` VALUES ('0ea7297e-89f2-4a2f-817f-9a243a1f6bbf','193237174-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',37800.00,'2023-03-17'),('12fe72d0-a96a-45d5-99f5-066fe81faba4','105173237-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','5a69591c-afa1-4a22-b49c-5d77ca3eaea2',3000.00,'2023-03-31'),('146c84ec-2764-42f7-b20c-8a8573995cef','129357992-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',3246.00,'2023-03-17'),('1ef3f245-342f-4e98-9a74-7b342a492e4f','145148376-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',20.00,'2023-03-13'),('5c78ee7e-e53a-4fe7-a26e-6379360c9b3e','153611083-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',400.00,'2023-05-02'),('617d6a71-1860-44c0-8e6e-45b971022d42','109303338-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',500.00,'2023-03-17'),('70115d19-ae18-40ff-97da-d64e9e4a27b3','197296740-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',12.00,'2023-03-17'),('740faabd-259a-4a21-a58b-bb95acc684f5','146574245-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','31e4a483-750f-4906-85b8-5f6fc473f3cf',100.00,'2023-05-02'),('7d154036-f86b-479f-a8c1-549d6f91a340','116979107-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',12.00,'2023-03-17'),('91fd39a2-7876-11ec-90ae-74d02be5638f','1231135-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','9677ed4a-43f1-433c-938e-80f0b39cd6df',10.00,'2022-01-18'),('9359e267-7876-11ec-90ae-74d02be5638f','1231135-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','9677ed4a-43f1-433c-938e-80f0b39cd6df',10.00,'2022-01-18'),('93e91239-7876-11ec-90ae-74d02be5638f','1231135-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','9677ed4a-43f1-433c-938e-80f0b39cd6df',10.00,'2022-01-18'),('95a53607-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23.00,'2022-01-16'),('ad6d8d08-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23.00,'2022-01-16'),('ae1b5a97-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23.00,'2022-01-16'),('af1faddb-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23.00,'2022-01-16'),('afc163ef-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23.00,'2022-01-16'),('b02c864d-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23.00,'2022-01-16'),('c49d2932-eb04-4b36-92d4-25041645e7b8','179661260-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',400.00,'2023-03-17'),('d7901bef-33fc-485f-acf9-853777e39cc4','145606239-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','bf836c9e-387f-4fe9-9919-0421d5b17ca0',10.00,'2023-03-13');
/*!40000 ALTER TABLE `collection` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_account`
--

DROP TABLE IF EXISTS `customer_account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer_account` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `address` varchar(200) NOT NULL,
  `contact_number` char(14) NOT NULL,
  PRIMARY KEY (`uid`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  KEY `idx_customer` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_account`
--

LOCK TABLES `customer_account` WRITE;
/*!40000 ALTER TABLE `customer_account` DISABLE KEYS */;
INSERT INTO `customer_account` VALUES ('071bac76-565e-4b99-bf5a-7e9515e15a8f','101934821-2022','Kirito Uzumaki','saldjhqdquh','8347624'),('0a2e3418-cd79-4e09-9196-fb15e5efb7be','111920785-2021','john wick','purok green leaves mibang','123989');
/*!40000 ALTER TABLE `customer_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_business_info`
--

DROP TABLE IF EXISTS `customer_business_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer_business_info` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) NOT NULL,
  `customer_uid` char(36) NOT NULL,
  `name` varchar(50) NOT NULL,
  `nature` varchar(50) DEFAULT NULL,
  `address` varchar(100) NOT NULL,
  `gross_business_capital` decimal(10,2) DEFAULT NULL,
  `average_daily_gross_sales` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`uid`),
  UNIQUE KEY `customer_uid` (`customer_uid`),
  KEY `bus_indx` (`customer_uid`),
  CONSTRAINT `FK_cusbusinesstocusaccount` FOREIGN KEY (`customer_uid`) REFERENCES `customer_account` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_business_info`
--

LOCK TABLES `customer_business_info` WRITE;
/*!40000 ALTER TABLE `customer_business_info` DISABLE KEYS */;
INSERT INTO `customer_business_info` VALUES ('993c7230-bfc5-44f6-b569-5b6538737fe9','101934821-2022','071bac76-565e-4b99-bf5a-7e9515e15a8f','asofihfoqh','aodiqodij','asofihfoqh',24876.00,23476.00),('b0f48705-28b9-434c-8e63-ec78c13bef8c','111920785-2021','0a2e3418-cd79-4e09-9196-fb15e5efb7be','asdkjh','akjh','asdkjh',122.00,123.00);
/*!40000 ALTER TABLE `customer_business_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `loan_information`
--

DROP TABLE IF EXISTS `loan_information`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `loan_information` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) DEFAULT NULL,
  `customer_uid` char(36) NOT NULL,
  `payment_term` varchar(50) NOT NULL,
  `duration` int NOT NULL,
  `effective_date` date NOT NULL,
  `interest` decimal(10,2) unsigned NOT NULL,
  `principal_loan` decimal(10,2) unsigned NOT NULL,
  `penalty` decimal(10,2) unsigned DEFAULT NULL,
  `status` varchar(50) DEFAULT 'Unpaid',
  PRIMARY KEY (`uid`),
  KEY `fk_loantocustomer_acc_idx` (`customer_uid`),
  CONSTRAINT `fk_loancustomerid_customerid` FOREIGN KEY (`customer_uid`) REFERENCES `customer_account` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loan_information`
--

LOCK TABLES `loan_information` WRITE;
/*!40000 ALTER TABLE `loan_information` DISABLE KEYS */;
INSERT INTO `loan_information` VALUES ('31e4a483-750f-4906-85b8-5f6fc473f3cf','126748266-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-03-21',20.00,1200.00,0.00,'Bad Debt'),('51f44357-5cef-11ec-bf7a-74d02be5638f','111920785-2020','0a2e3418-cd79-4e09-9196-fb15e5efb7be','daily',30,'2021-12-14',0.20,1200.00,0.00,'Bad Debt'),('563561ba-3b52-4afd-9883-3a9f40885625','177859217-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',30,'2022-04-28',20.00,1000.00,0.00,'Unpaid'),('5a69591c-afa1-4a22-b49c-5d77ca3eaea2','152924695-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',30,'2023-03-31',2.00,1000.00,0.00,'Fully Paid'),('80aa37ec-629d-4e88-bdd5-e59e614ab7e4','154323717-2022','071bac76-565e-4b99-bf5a-7e9515e15a8f','Daily',30,'2022-05-29',20.00,1000.00,0.00,'Fully Paid'),('9677ed4a-43f1-433c-938e-80f0b39cd6df','198037871-2021','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',30,'2021-12-19',20.00,1000.00,0.00,'Fully Paid'),('bf836c9e-387f-4fe9-9919-0421d5b17ca0','166840711-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-11-01',20.00,2000.00,0.00,'Fully Paid'),('f7cf751a-2468-4afc-a8e1-b9be79caa87c','138968069-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-03-21',20.00,1000.00,0.00,'Fully Paid'),('fbcc229a-7f5b-4119-9efb-985805dde8b7','141070883-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-03-21',20.00,23.00,0.00,'Bad Debt');
/*!40000 ALTER TABLE `loan_information` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `penalty`
--

DROP TABLE IF EXISTS `penalty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `penalty` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) DEFAULT NULL,
  `customer_uid` char(36) NOT NULL,
  `loan_information_uid` char(36) NOT NULL,
  `amount` decimal(10,2) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`uid`),
  KEY `index2` (`id`),
  KEY `fk_customer_uid_index` (`customer_uid`),
  KEY `fk_penalty_loan_information_uid_idx` (`loan_information_uid`),
  CONSTRAINT `fk_penalty_customer_account_uid` FOREIGN KEY (`customer_uid`) REFERENCES `customer_account` (`uid`),
  CONSTRAINT `fk_penalty_loan_information_uid` FOREIGN KEY (`loan_information_uid`) REFERENCES `loan_information` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `penalty`
--

LOCK TABLES `penalty` WRITE;
/*!40000 ALTER TABLE `penalty` DISABLE KEYS */;
INSERT INTO `penalty` VALUES ('3f9b80f0-0c9c-45a2-bfac-3fc6ef1cee9d','123419433-2023','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',100.00,'2023-05-02');
/*!40000 ALTER TABLE `penalty` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_system_account`
--

DROP TABLE IF EXISTS `user_system_account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_system_account` (
  `uid` char(36) NOT NULL,
  `id` varchar(100) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`uid`),
  KEY `idx_user` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_system_account`
--

LOCK TABLES `user_system_account` WRITE;
/*!40000 ALTER TABLE `user_system_account` DISABLE KEYS */;
INSERT INTO `user_system_account` VALUES ('466414dd-b2b8-11ec-82b2-fc349701f832','123','user','user');
/*!40000 ALTER TABLE `user_system_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `v_customerinformation`
--

DROP TABLE IF EXISTS `v_customerinformation`;
/*!50001 DROP VIEW IF EXISTS `v_customerinformation`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_customerinformation` AS SELECT 
 1 AS `id`,
 1 AS `name`,
 1 AS `address`,
 1 AS `contact_number`,
 1 AS `BusinessName`,
 1 AS `BusinessNature`,
 1 AS `BusinessAddress`,
 1 AS `gross_business_capital`,
 1 AS `average_daily_gross_sales`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_loaninformation`
--

DROP TABLE IF EXISTS `v_loaninformation`;
/*!50001 DROP VIEW IF EXISTS `v_loaninformation`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_loaninformation` AS SELECT 
 1 AS `LoanID`,
 1 AS `CustomerID`,
 1 AS `CustomerName`,
 1 AS `PaymentTerm`,
 1 AS `Duration`,
 1 AS `EffectiveDate`,
 1 AS `Interest`,
 1 AS `PrincipalLoan`,
 1 AS `Penalty`,
 1 AS `Status`,
 1 AS `Amount`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'tjpdb'
--

--
-- Dumping routines for database 'tjpdb'
--
/*!50003 DROP PROCEDURE IF EXISTS `sp_createLoanInformationReport` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_createLoanInformationReport`(
	IN loan_id varchar(100)
)
BEGIN
	select
	v_loaninformation.LoanID,
	v_loaninformation.CustomerID,
    v_loaninformation.CustomerName,
    v_loaninformation.PrincipalLoan,
    v_loaninformation.Interest,
    v_loaninformation.PrincipalLoan + (v_loaninformation.PrincipalLoan * v_loaninformation.Interest) as 'TotalLoan',
    (v_loaninformation.PrincipalLoan + (v_loaninformation.PrincipalLoan * v_loaninformation.Interest)) / v_loaninformation.Duration as 'DailyPayment',
    v_loaninformation.PaymentTerm	
	from v_loaninformation where
	v_loaninformation.LoanID like concat(loan_id,'%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getCollectionAndPenalty` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getCollectionAndPenalty`(
	IN loanId varchar(100)
)
BEGIN
	select
		b.id as ID,
        b.amount as Collection,
		b.date as 'Date',			
        case
			when c.amount is null
            then 0
            else c.amount
            end as Penalty        
		from loan_information as a
		left join collection as b on a.uid = b.loan_information_uid
		left join penalty as c on a.uid = c.loan_information_uid
        where a.id = loanId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getCustomer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getCustomer`(
	IN customerId varchar(100)
)
BEGIN
select v_customerinformation.id as id,
v_customerinformation.name as name,
v_customerinformation.address as address,
v_customerinformation.contact_number as contactnumber,
v_customerinformation.BusinessName as BusinessName,
v_customerinformation.BusinessNature as BusinessNature,
v_customerinformation.BusinessAddress as BusinessAddress,
v_customerinformation.gross_business_capital as grossbusinesscapital,
v_customerinformation.average_daily_gross_sales as averagedailygrosssales
from v_customerinformation where
v_customerinformation.id = customerId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getCustomerGuid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getCustomerGuid`(
	IN customerId varchar(100)
)
BEGIN
	select uid from customer_account
    where id = customerId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getCustomerList` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getCustomerList`(
	IN customerId varchar(100),
    IN customerName varchar(100)
)
BEGIN
select v_customerinformation.id as id,
v_customerinformation.name as name,
v_customerinformation.address as address,
v_customerinformation.contact_number as contactnumber,
v_customerinformation.BusinessName as BusinessName,
v_customerinformation.BusinessNature as BusinessNature,
v_customerinformation.BusinessAddress as BusinessAddress,
v_customerinformation.gross_business_capital as grossbusinesscapital,
v_customerinformation.average_daily_gross_sales as averagedailygrosssales
from v_customerinformation where
v_customerinformation.id like concat(customerId,'%') or
v_customerinformation.name like concat(customerName,'%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getLoanGuid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getLoanGuid`(
	IN loanId varchar(100)
)
BEGIN
	select uid from loan_information
    where id = loanId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getLoanInformation` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getLoanInformation`(
	IN customerId varchar(100),
    IN customerName varchar(100)    
)
BEGIN
	select
	v_loaninformation.LoanID,
	v_loaninformation.CustomerID,
	v_loaninformation.CustomerName,
	v_loaninformation.PaymentTerm,
	v_loaninformation.Duration,
	v_loaninformation.EffectiveDate,
	v_loaninformation.Interest,
	v_loaninformation.PrincipalLoan,
	v_loaninformation.Penalty,
	v_loaninformation.Status,
    v_loaninformation.Amount
	from v_loaninformation where
	v_loaninformation.CustomerID like concat(customerId,'%') or
	v_loaninformation.CustomerName like concat(customerName,'%');    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getLoanInformationUsingLoanId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getLoanInformationUsingLoanId`(
	IN loan_id varchar(100)
)
BEGIN
	select
	v_loaninformation.LoanID,
	v_loaninformation.CustomerID,
	v_loaninformation.CustomerName,
	v_loaninformation.PaymentTerm,
	v_loaninformation.Duration,
	v_loaninformation.EffectiveDate,
	v_loaninformation.Interest,
	v_loaninformation.PrincipalLoan,
	v_loaninformation.Penalty,
	v_loaninformation.Status,
    v_loaninformation.Amount
	from v_loaninformation where
	v_loaninformation.LoanID like concat(loan_id,'%');
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getPostingList` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getPostingList`(
	IN customerIdOrName varchar(100)
)
BEGIN	
	SET sql_mode = '';
    
    select DATE_ADD(loan.effective_date, INTERVAL loan.duration DAY) as 'Due',
	loan.id as 'Loan No',
	customer.name as 'Name',
	loan.principal_loan as 'Return',
	truncate(loan.principal_loan * loan.interest,2) as 'Interest',
	truncate((loan.principal_loan * loan.interest) + loan.principal_loan,2) as 'Total Loan Amount',
	loan.status as 'Status',
    case
		when Sum(col.amount) is null
        then 0
        else Sum(col.amount)
		end as 'Total Amount Collected'
	from loan_information as loan
	Left Join customer_account as customer on loan.customer_uid = customer.uid
	Left join collection as col on loan.uid = col.loan_information_uid
	where (customer.id = customerIdOrName OR customer.name like concat(customerIdOrName,'%'))
	AND loan.status <> 'Fully Paid'
    group by loan.id
    order by loan.effective_date asc;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getReleasedAmount` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getReleasedAmount`(
	IN loan_id varchar(100)
)
BEGIN
		DROP TEMPORARY TABLE IF EXISTS temp;
		CREATE TEMPORARY TABLE temp(
			select
			v_loaninformation.LoanID,
			v_loaninformation.CustomerID,
			v_loaninformation.CustomerName,
			v_loaninformation.PaymentTerm,
			v_loaninformation.Duration,
			v_loaninformation.EffectiveDate,
			v_loaninformation.Interest,
			v_loaninformation.PrincipalLoan,
			v_loaninformation.Penalty,
			v_loaninformation.Status,
			v_loaninformation.Amount
			from v_loaninformation where
			v_loaninformation.LoanID like concat(loan_id,'%')        
		);
        select (PrincipalLoan * 0.2) + PrincipalLoan as 'Release Amount' from temp;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getTotalCollection` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getTotalCollection`(
	IN customerUid char(36)
)
BEGIN
	select c.id,c.name,sum(cl.amount) as totalCollection from collection as cl
	inner join customer_account as c on cl.customer_uid = c.uid
    where cl.customer_uid = customerUid
    group by c.id, c.name;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_getTotalCollectionPerLoanSummary` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getTotalCollectionPerLoanSummary`(

)
BEGIN	
	select loan.id as 'ID',c.name as 'Name_of_the_Owner',
    loan.principal_loan + (loan.principal_loan * 0.2)  as 'Released_Amount_with_Interest',
    Sum(cl.amount) as 'Total_Collection' from collection as cl
	left join customer_account as c on cl.customer_uid = c.uid
    left join loan_information as loan on cl.loan_information_uid = loan.uid
    group by loan.id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insertCollection` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insertCollection`(
	IN collectionUid char(36),
    IN collectionId varchar(100),
    IN customerUid char(36),
    IN loanInformationUid varchar(100),
    IN collectionAmount int,
	IN collectionDate date
)
BEGIN
	insert into collection(uid,id,customer_uid,loan_information_uid,amount,`date`)
    values(collectionUid,collectionId,customerUid,loanInformationUid,collectionAmount,collectionDate);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insertCustomer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insertCustomer`(
	IN customerUid char(36),
	IN customerId varchar(100),
	IN customerName varchar(100),
	IN address varchar(200),
	IN contactNumber int,
	IN businessUid char(36), 
	IN businessId varchar(100),
	IN businessName varchar(50),
	IN businessNature varchar(50),
	IN businessAddress varchar(100),
	IN grossBusinessCapital decimal(10,5),
	IN averageDailyGrossSales decimal(10,5)
)
BEGIN
	INSERT INTO `tjpdb`.`customer_account`
	(`uid`,
	`id`,
	`name`,
	`address`,
	`contact_number`)
	VALUES
	(trim(customerUid),trim(customerId),trim(customerName),
    address,contactNumber);
    
    INSERT INTO `tjpdb`.`customer_business_info`
	(`uid`,
	`id`,
	`customer_uid`,
	`name`,
	`nature`,
	`address`,
	`gross_business_capital`,
	`average_daily_gross_sales`)
	VALUES
	(trim(businessUid),
    trim(businessId),
    trim(customerUId),
    trim(businessName),
    businessNature,
    businessAddress,
    grossBusinessCapital,
    averageDailyGrossSales
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insertLoan` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insertLoan`(
	IN loaninformationUid char(36),
    IN loaninformationId varchar(100),
    IN customerUid char(36),
    IN paymentTerm varchar(50),
    IN duration int,
    IN effectiveDate date,
    IN interest decimal(10,2),
    IN principalLoan decimal(10,2),
    IN penalty decimal(10,2)    
)
BEGIN
	INSERT INTO `tjpdb`.`loan_information`
	(`uid`,
	`id`,
	`customer_uid`,
	`payment_term`,
	`duration`,
	`effective_date`,
	`interest`,
	`principal_loan`,
	`penalty`)
	VALUES
	(
		loaninformationUid,
		loaninformationId,
		customerUid,
		paymentTerm,
		duration,
		effectiveDate,
		interest,
		principalLoan,
		penalty	
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_insertPenalty` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insertPenalty`(
	IN penalty_Uid char(36),
    IN penalty_Id varchar(100),
    IN customer_Uid char(36),
    IN loanInformation_Uid varchar(100),
    IN penalty_Amount int,
	IN penalty_Date date
)
BEGIN
	insert into penalty(uid,id,customer_uid,loan_information_uid,amount,`date`)
    values(penalty_Uid,penalty_Id,customer_Uid,loanInformation_Uid,penalty_Amount,penalty_Date);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_isLoanUnpaid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_isLoanUnpaid`(
IN ID varchar(50),
OUT rslt tinyint(1))
BEGIN
	DECLARE status_result boolean;
	SELECT IF(Status='Unpaid',1,0)
	INTO status_result
	FROM v_loaninformation
	WHERE CustomerID = ID and Status = 'Unpaid';   
    Set rslt = status_result;
	SELECT ifnull(rslt,0) as Status;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateCustomer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateCustomer`(
IN customerId varchar(100),
IN customerName varchar(100),
IN address varchar(200),
IN contactNumber char(14),
IN businessName varchar(50),
IN businessNature varchar(50),
IN businessAddress varchar(100),
IN grossBusinessCapital decimal(10,5),
IN averageDailyGrossSales decimal(10,5)
)
BEGIN
	UPDATE `tjpdb`.`customer_account`
	SET		
	`name` = customerName,
	`address` = address,
	`contact_number` = contactNumber
	WHERE `id` = customerId;
	
    UPDATE `tjpdb`.`customer_business_info`
	SET		
	`name` = businessName,
	`nature` = businessNature,
	`address` = businessAddress,
	`gross_business_capital` = grossBusinessCapital,
	`average_daily_gross_sales` = averageDailyGrossSales
	WHERE `id` = customerId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateLoanStatus` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateLoanStatus`(
	IN loanId varchar(100)
)
BEGIN
	update loan_information set status = 'Fully Paid' where id = loanId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `v_customerinformation`
--

/*!50001 DROP VIEW IF EXISTS `v_customerinformation`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_customerinformation` AS select `customeraccount`.`id` AS `id`,`customeraccount`.`name` AS `name`,`customeraccount`.`address` AS `address`,`customeraccount`.`contact_number` AS `contact_number`,`businessinfo`.`name` AS `BusinessName`,`businessinfo`.`nature` AS `BusinessNature`,`businessinfo`.`address` AS `BusinessAddress`,`businessinfo`.`gross_business_capital` AS `gross_business_capital`,`businessinfo`.`average_daily_gross_sales` AS `average_daily_gross_sales` from (`customer_account` `customeraccount` join `customer_business_info` `businessinfo` on((`customeraccount`.`uid` = `businessinfo`.`customer_uid`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_loaninformation`
--

/*!50001 DROP VIEW IF EXISTS `v_loaninformation`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_loaninformation` AS select `loan`.`id` AS `LoanID`,`customer`.`id` AS `CustomerID`,`customer`.`name` AS `CustomerName`,`loan`.`payment_term` AS `PaymentTerm`,`loan`.`duration` AS `Duration`,`loan`.`effective_date` AS `EffectiveDate`,`loan`.`interest` AS `Interest`,`loan`.`principal_loan` AS `PrincipalLoan`,`loan`.`penalty` AS `Penalty`,`loan`.`status` AS `Status`,sum(`collect`.`amount`) AS `Amount` from ((`loan_information` `loan` left join `collection` `collect` on((`loan`.`uid` = `collect`.`loan_information_uid`))) left join `customer_account` `customer` on((`loan`.`customer_uid` = `customer`.`uid`))) group by `loan`.`id`,`customer`.`id`,`customer`.`name`,`loan`.`payment_term`,`loan`.`duration`,`loan`.`effective_date`,`loan`.`interest`,`loan`.`principal_loan`,`loan`.`penalty`,`loan`.`status` */;
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

-- Dump completed on 2023-05-02 11:40:05
