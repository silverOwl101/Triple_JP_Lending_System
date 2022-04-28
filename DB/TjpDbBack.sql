CREATE DATABASE  IF NOT EXISTS `tjpdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `tjpdb`;
-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: tjpdb
-- ------------------------------------------------------
-- Server version	8.0.25

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
  `amount` decimal(10,0) NOT NULL,
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
INSERT INTO `collection` VALUES ('91fd39a2-7876-11ec-90ae-74d02be5638f','1231135-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','9677ed4a-43f1-433c-938e-80f0b39cd6df',10,'2022-01-18'),('9359e267-7876-11ec-90ae-74d02be5638f','1231135-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','9677ed4a-43f1-433c-938e-80f0b39cd6df',10,'2022-01-18'),('93e91239-7876-11ec-90ae-74d02be5638f','1231135-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','9677ed4a-43f1-433c-938e-80f0b39cd6df',10,'2022-01-18'),('95a53607-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23,'2022-01-16'),('ad6d8d08-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23,'2022-01-16'),('ae1b5a97-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23,'2022-01-16'),('af1faddb-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23,'2022-01-16'),('afc163ef-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23,'2022-01-16'),('b02c864d-76e3-11ec-9684-74d02be5638f','2021-22314414','0a2e3418-cd79-4e09-9196-fb15e5efb7be','51f44357-5cef-11ec-bf7a-74d02be5638f',23,'2022-01-16');
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
INSERT INTO `loan_information` VALUES ('08156fdd-fe23-4402-8456-d66c0c6f47db','165449826-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-04-28',20.00,30000.00,0.00,'Unpaid'),('31e4a483-750f-4906-85b8-5f6fc473f3cf','126748266-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-03-21',20.00,1200.00,0.00,'Bad Debt'),('51f44357-5cef-11ec-bf7a-74d02be5638f','111920785-2020','0a2e3418-cd79-4e09-9196-fb15e5efb7be','daily',30,'2021-12-14',0.20,1200.00,0.00,'Bad Debt'),('563561ba-3b52-4afd-9883-3a9f40885625','177859217-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',30,'2022-04-28',20.00,1000.00,0.00,'Fully Paid'),('56448b4d-d27f-4e90-a0b4-11cc8c02e45c','195036786-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',30,'2022-01-20',20.00,100.00,0.00,'Unpaid'),('60dbbff8-ccc3-40ec-b84d-94b85cab81e3','127659769-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-03-25',20.00,12344.00,0.00,'Unpaid'),('90b4a75d-775c-4f3b-8f90-e0e33e4558f6','119829482-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-03-21',20.00,1000.00,0.00,'Unpaid'),('9677ed4a-43f1-433c-938e-80f0b39cd6df','198037871-2021','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',30,'2021-12-19',20.00,1000.00,0.00,'Fully Paid'),('dd85ad48-559e-4c27-a183-927bee9717a7','179130232-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',30,'2022-04-28',20.00,1000.00,0.00,'Unpaid'),('f7cf751a-2468-4afc-a8e1-b9be79caa87c','138968069-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-03-21',20.00,1000.00,0.00,'Fully Paid'),('fbcc229a-7f5b-4119-9efb-985805dde8b7','141070883-2022','0a2e3418-cd79-4e09-9196-fb15e5efb7be','Daily',60,'2022-03-21',20.00,23.00,0.00,'Bad Debt');
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
  `amount` decimal(10,5) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `penalty`
--

LOCK TABLES `penalty` WRITE;
/*!40000 ALTER TABLE `penalty` DISABLE KEYS */;
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
/*!50003 DROP PROCEDURE IF EXISTS `sp_getCollectionAndPenalty` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getCollectionAndPenalty`(
	IN loanId varchar(100)
)
BEGIN
	select 	b.date as Date,		
		b.amount as Collection,        
        c.amount as Penalty
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
/*!50003 DROP PROCEDURE IF EXISTS `sp_getLoanInformation` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
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
/*!50003 DROP PROCEDURE IF EXISTS `sp_getTotalCollection` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_getTotalCollection`(
	IN customerUid char(36)
)
BEGIN
	select c.id,c.name,sum(cl.returned) as totalCollection from collection as cl
	inner join customer_account as c on cl.customer_uid = c.uid
    where cl.customer_uid = customerUid;
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
/*!50001 VIEW `v_loaninformation` AS select `loan`.`id` AS `LoanID`,`customer`.`id` AS `CustomerID`,`customer`.`name` AS `CustomerName`,`loan`.`payment_term` AS `PaymentTerm`,`loan`.`duration` AS `Duration`,`loan`.`effective_date` AS `EffectiveDate`,`loan`.`interest` AS `Interest`,`loan`.`principal_loan` AS `PrincipalLoan`,`loan`.`penalty` AS `Penalty`,`loan`.`status` AS `Status`,sum(`collect`.`amount`) AS `Amount` from ((`loan_information` `loan` left join `collection` `collect` on((`loan`.`uid` = `collect`.`loan_information_uid`))) left join `customer_account` `customer` on((`loan`.`customer_uid` = `customer`.`uid`))) group by `loan`.`id` */;
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

-- Dump completed on 2022-04-28 21:38:55
