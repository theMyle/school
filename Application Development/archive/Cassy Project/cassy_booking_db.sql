/*
SQLyog Community v13.3.0 (64 bit)
MySQL - 10.4.32-MariaDB : Database - cassy_booking_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`cassy_booking_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `cassy_booking_db`;

/*Table structure for table `events` */

DROP TABLE IF EXISTS `events`;

CREATE TABLE `events` (
  `event_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `event_name` varchar(100) DEFAULT NULL,
  `customer_name` varchar(50) DEFAULT NULL,
  `customer_phone` varchar(20) DEFAULT NULL,
  `customer_address` varchar(254) DEFAULT NULL,
  `event_type` varchar(50) DEFAULT NULL,
  `event_date_time` datetime DEFAULT NULL,
  `event_guests` int(11) DEFAULT NULL,
  `event_theme` varchar(50) DEFAULT NULL,
  `event_status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`event_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `events` */

insert  into `events`(`event_id`,`event_name`,`customer_name`,`customer_phone`,`customer_address`,`event_type`,`event_date_time`,`event_guests`,`event_theme`,`event_status`) values 
(1,'Cassy Birthday','Cassandra D.','09123456789','Gubat Sorsogon','party','2024-12-28 06:30:00',100,'Flowers','Scheduled'),
(3,'Sumami Party','Sumami Uy','12345678919','Sorsogon City','party','2024-12-20 06:30:00',100,'Swimsuit','Scheduled'),
(4,'John Doe Party','John D.','09123841947','Sorsogon City','party','2024-12-27 06:30:00',50,'Any','Scheduled'),
(9,'Maria Party','Maria D.','09123456789','Sorsogon City','party','2024-12-29 06:30:00',50,'Any','Scheduled'),
(10,'Habibi Conference','Habibi M.','06969696969','Sorsogon City','conference','2024-12-19 06:30:00',50,'Santa','Scheduled');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
