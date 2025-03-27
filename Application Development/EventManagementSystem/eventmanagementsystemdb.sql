/*
SQLyog Community v13.3.0 (64 bit)
MySQL - 10.4.32-MariaDB : Database - eventbooking_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`eventbooking_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `eventbooking_db`;

/*Table structure for table `accounts` */

DROP TABLE IF EXISTS `accounts`;

CREATE TABLE `accounts` (
  `username` varchar(254) NOT NULL,
  `password` varchar(254) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `accounts` */

insert  into `accounts`(`username`,`password`) values 
('admin','admin');

/*Table structure for table `customers` */

DROP TABLE IF EXISTS `customers`;

CREATE TABLE `customers` (
  `customer_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `customer_name` varchar(60) NOT NULL,
  `customer_phone` varchar(20) NOT NULL,
  `customer_email` varchar(254) DEFAULT NULL,
  `customer_address` varchar(254) NOT NULL,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `customers` */

insert  into `customers`(`customer_id`,`customer_name`,`customer_phone`,`customer_email`,`customer_address`) values 
(1,'John Kenneth Belano','09123456789','jkb@gmail.com','Ticol Sorsogon City'),
(2,'Ashlyn Alama','09123456788','aslyn@gmail.com','Manila Zoo'),
(3,'Prince Aaron Tuquero','09123456777','pwince@gmai.com','Zambales City'),
(4,'Joe Guab','09123456666','guab@gmai.com','Sorsogon Zoo'),
(5,'Father Jose','09696969696','fatherJose@gmail.com','Sorsogon City'),
(6,'Zumami Lazuli','09123456783','lapizLazuli@gmail.com','Cambulaga Sorsogon City'),
(7,'Zumami Lazuli','09123456789','','Cambulaga Sorsogon City'),
(8,'Lapis Lazuli','09123456789','','Cambulaga Sorsogon City'),
(9,'saasa','1','','asdsd');

/*Table structure for table `events` */

DROP TABLE IF EXISTS `events`;

CREATE TABLE `events` (
  `event_id` int(10) unsigned NOT NULL AUTO_INCREMENT COMMENT 'event unique ID',
  `event_name` varchar(100) NOT NULL COMMENT 'name of event',
  `event_type` varchar(100) NOT NULL COMMENT 'type of event (eg; bday, party, wedding)',
  `date_booked` date NOT NULL,
  `event_start_datetime` datetime NOT NULL COMMENT 'date of event',
  `event_end_date` date NOT NULL COMMENT 'duration of event',
  `number_of_guests` int(10) unsigned NOT NULL COMMENT 'expected no. of guests',
  `event_preferences` varchar(254) NOT NULL COMMENT 'theme (eg; spiderman, horror, etc..)',
  `status` varchar(50) NOT NULL COMMENT 'event status (pending, ongoing, ended)',
  `customer_id` int(10) unsigned NOT NULL,
  PRIMARY KEY (`event_id`),
  KEY `customer_has_event` (`customer_id`),
  CONSTRAINT `customer_has_event` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `events` */

insert  into `events`(`event_id`,`event_name`,`event_type`,`date_booked`,`event_start_datetime`,`event_end_date`,`number_of_guests`,`event_preferences`,`status`,`customer_id`) values 
(2,'Party ni alama','Party','0000-00-00','2024-12-13 06:30:00','2024-12-13',100,'School Uniform','ongoing',2),
(7,'Father Jose Church','Church Event','0000-00-00','2024-12-15 07:30:00','2024-12-15',50,'Formal Church Attire','scheduled',5),
(8,'Father Jose Party','Party','0000-00-00','2024-12-22 07:30:00','2024-12-22',100,'Swimsuit','scheduled',5),
(10,'Hindi Ito Scam Event','Business Event','0000-00-00','2024-12-17 07:30:00','2024-12-17',200,'brip','scheduled',1),
(11,'Minecraft Gaming Conference','Conference','2024-12-13','2024-12-26 06:30:00','2024-12-26',500,'People who showered (ONLY)\r\nEXCULSIVELY','scheduled',8);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
