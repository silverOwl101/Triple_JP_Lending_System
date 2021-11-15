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
  `uid` binary(255) NOT NULL,
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
/*!40000 ALTER TABLE `administrator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `collection`
--

DROP TABLE IF EXISTS `collection`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `collection` (
  `uid` binary(255) NOT NULL,
  `customeruid` binary(255) NOT NULL,
  `loan_transaction_uid` binary(255) NOT NULL,
  `return` decimal(10,0) NOT NULL,
  `interest` decimal(10,0) NOT NULL,
  `date` date NOT NULL,
  KEY `idx_collection` (`uid`,`customeruid`),
  KEY `fk_coltocustomeracc_tbl_idx` (`customeruid`),
  KEY `fk_coltoloan_tbl_idx` (`loan_transaction_uid`),
  CONSTRAINT `fk_coltocustomeracc_tbl` FOREIGN KEY (`customeruid`) REFERENCES `customer_account` (`uid`),
  CONSTRAINT `fk_coltoloan_tbl` FOREIGN KEY (`loan_transaction_uid`) REFERENCES `loan_information` (`uid`)
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
  `uid` binary(255) NOT NULL,
  `id` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `address` varchar(200) NOT NULL,
  `contact_number` int NOT NULL,
  `customer_accountcol` varchar(45) DEFAULT NULL,
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
/*!40000 ALTER TABLE `customer_account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_business_info`
--

DROP TABLE IF EXISTS `customer_business_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer_business_info` (
  `uid` binary(255) NOT NULL,
  `customeruid` binary(255) NOT NULL,
  `name` varchar(50) NOT NULL,
  `nature` varchar(50) DEFAULT NULL,
  `address` varchar(100) NOT NULL,
  `gross_business_capital` decimal(10,5) DEFAULT NULL,
  `average_daily_gross_sales` decimal(10,5) DEFAULT NULL,
  PRIMARY KEY (`uid`),
  CONSTRAINT `fk_busitocustomeracc_tbl` FOREIGN KEY (`uid`) REFERENCES `customer_account` (`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_business_info`
--

LOCK TABLES `customer_business_info` WRITE;
/*!40000 ALTER TABLE `customer_business_info` DISABLE KEYS */;
/*!40000 ALTER TABLE `customer_business_info` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `loan_information`
--

DROP TABLE IF EXISTS `loan_information`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `loan_information` (
  `uid` binary(255) NOT NULL,
  `customeruid` binary(255) NOT NULL,
  `payment_term` int NOT NULL,
  `duration` int NOT NULL,
  `effective_date` date NOT NULL,
  `interest` decimal(10,0) NOT NULL,
  `principal loan` decimal(10,0) NOT NULL,
  `penalty` decimal(10,0) NOT NULL,
  `status` varchar(50) NOT NULL,
  PRIMARY KEY (`uid`)
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
  `uid` binary(255) NOT NULL,
  `customeruid` binary(255) NOT NULL,
  `loan_transaction_uid` binary(255) NOT NULL,
  `amount` decimal(10,5) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`uid`),
  KEY `fk_penaltytocustomeracc_tbl_idx` (`customeruid`),
  KEY `fk_penaltytoloan_idx` (`loan_transaction_uid`),
  CONSTRAINT `fk_penaltytocustomeracc_tbl` FOREIGN KEY (`customeruid`) REFERENCES `customer_account` (`uid`),
  CONSTRAINT `fk_penaltytoloan` FOREIGN KEY (`loan_transaction_uid`) REFERENCES `loan_information` (`uid`)
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
-- Dumping events for database 'tjpdb'
--

--
-- Dumping routines for database 'tjpdb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-15 22:01:15
