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
  `return` decimal(10,0) NOT NULL,
  `interest` decimal(10,0) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`uid`),
  KEY `colIndex` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `collection`
--

LOCK TABLES `collection` WRITE;
/*!40000 ALTER TABLE `collection` DISABLE KEYS */;
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
INSERT INTO `customer_account` VALUES ('0a2e3418-cd79-4e09-9196-fb15e5efb7be','111920785-2021','john keneth','adkjahdkq','123989');
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
INSERT INTO `customer_business_info` VALUES ('b0f48705-28b9-434c-8e63-ec78c13bef8c','111920785-2021','0a2e3418-cd79-4e09-9196-fb15e5efb7be','asdkjh','akjh','asdkjh',123.00,123.00);
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
  `payment_term` int NOT NULL,
  `duration` int NOT NULL,
  `effective_date` date NOT NULL,
  `interest` decimal(10,0) NOT NULL,
  `principal_loan` decimal(10,0) NOT NULL,
  `penalty` decimal(10,0) NOT NULL,
  `status` varchar(50) NOT NULL,
  PRIMARY KEY (`uid`),
  KEY `fk_loantocustomer_acc_idx` (`customer_uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loan_information`
--

LOCK TABLES `loan_information` WRITE;
/*!40000 ALTER TABLE `loan_information` DISABLE KEYS */;
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
-- Dumping events for database 'tjpdb'
--

--
-- Dumping routines for database 'tjpdb'
--
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
v_customerinformation.id like concat('%',customerId,'%') or
v_customerinformation.name like concat('%',customerName,'%');
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
IN name varchar(100),
IN address varchar(200),
IN contact_number int,
IN businessName varchar(50),
IN businessNature varchar(50),
IN businessAddress varchar(100),
IN grossBusinessCapital decimal(10,5),
IN averageDailyGrossSales decimal(10,5)
)
BEGIN
	UPDATE `tjpdb`.`customer_account`
	SET		
	`name` = name,
	`address` = address,
	`contact_number` = contact_number
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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-03 22:07:37
