/*
SQLyog Community v13.2.0 (64 bit)
MySQL - 8.0.34 : Database - db_studentaccountingmanagement
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_studentaccountingmanagement` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `db_studentaccountingmanagement`;

/*Table structure for table `tbladmin` */

DROP TABLE IF EXISTS `tbladmin`;

CREATE TABLE `tbladmin` (
  `id` int NOT NULL AUTO_INCREMENT,
  `adminid` varchar(7) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `adminid` (`adminid`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tbladmin` */

insert  into `tbladmin`(`id`,`adminid`,`lastname`,`firstname`,`middlename`) values 
(1,'136626','Nazareno','Dennis','Monton'),
(2,'125356','Manon-og','Kenneth','Crisostomo'),
(3,'134563','Alvez','Cyril Charles','Ojena'),
(4,'126403','Romart','Bitte','Villanueva');

/*Table structure for table `tbladminusers` */

DROP TABLE IF EXISTS `tbladminusers`;

CREATE TABLE `tbladminusers` (
  `id` int NOT NULL AUTO_INCREMENT,
  `adminid` varchar(10) NOT NULL,
  `password` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `adminid_UNIQUE` (`adminid`),
  CONSTRAINT `tbladminusers_ibfk_1` FOREIGN KEY (`adminid`) REFERENCES `tbladmin` (`adminid`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tbladminusers` */

insert  into `tbladminusers`(`id`,`adminid`,`password`) values 
(2,'134563','qwerty');

/*Table structure for table `tblassessment` */

DROP TABLE IF EXISTS `tblassessment`;

CREATE TABLE `tblassessment` (
  `id` int NOT NULL AUTO_INCREMENT,
  `description` varchar(100) NOT NULL,
  `amount` decimal(11,0) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tblassessment` */

insert  into `tblassessment`(`id`,`description`,`amount`) values 
(1,'Per Unit Fee',8930),
(2,'Athletics Fee',300),
(3,'Audio Visual Fee',300),
(4,'Modernization',1375),
(5,'Guidance Fee',290),
(6,'Library Fee',1100),
(7,'Medical Fee',320),
(8,'Registration Fee',370),
(9,'IT Development Fee',150),
(10,'Psychological Fee',225);

/*Table structure for table `tblbalance` */

DROP TABLE IF EXISTS `tblbalance`;

CREATE TABLE `tblbalance` (
  `id` int NOT NULL AUTO_INCREMENT,
  `stid` int NOT NULL,
  `totalbalance` decimal(11,0) NOT NULL DEFAULT '0',
  `totalpayment` decimal(11,0) NOT NULL DEFAULT '0',
  `remainingbalance` decimal(11,0) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `fk_balanceStid` (`stid`),
  CONSTRAINT `fk_balanceStid` FOREIGN KEY (`stid`) REFERENCES `tblstudent` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tblbalance` */

insert  into `tblbalance`(`id`,`stid`,`totalbalance`,`totalpayment`,`remainingbalance`) values 
(6,1,0,0,0),
(7,2,0,0,0),
(8,3,0,0,0),
(9,4,0,0,0),
(12,7,0,0,0),
(13,8,0,0,0);

/*Table structure for table `tblstudent` */

DROP TABLE IF EXISTS `tblstudent`;

CREATE TABLE `tblstudent` (
  `id` int NOT NULL AUTO_INCREMENT,
  `studentid` varchar(10) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `gender` varchar(10) NOT NULL,
  `birthdate` date NOT NULL,
  `mobileno` varchar(50) NOT NULL,
  `emailadd` varchar(100) NOT NULL,
  `address` varchar(200) NOT NULL,
  `yearlevel` int NOT NULL,
  `program` varchar(6) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `studentid` (`studentid`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tblstudent` */

insert  into `tblstudent`(`id`,`studentid`,`lastname`,`firstname`,`middlename`,`gender`,`birthdate`,`mobileno`,`emailadd`,`address`,`yearlevel`,`program`) values 
(1,'123456','Pañer','Jonald','Morante','Male','2023-10-03','09123445678','jonald@gmail.com','Sto tomas, Davao del Norte',3,'BSCS'),
(2,'133752','Lubay','Jamyca','Guod','Female','2023-05-16','09123445678','jamyca@gmail.com','Tagum City, Davao del Norte',3,'BSCS'),
(3,'129092','Tanaid','Cathlyn','Andilag','Female','2023-11-04','09123445678','tanaid@gmail.com','Tagum City, Davao del Norte',3,'BSCS'),
(4,'135324','Jumao-as','Princess Dianne','Dellera','Female','2023-08-08','09123445678','jumaoas@gmail.com','Sto Tomas, Davao del Norte',3,'BSCS'),
(7,'142574','Riparip','Reggie',' ','Male','2023-11-13','09123445678','riparip@gmail.com','Tagum City, Davao del Norte',3,'BSIT'),
(8,'164732','Carreon','Chris Alden',' ','Male','2023-11-13','09123445678','carreon@gmail.com','Tagum City, Davao del Norte',3,'BSIT');

/*Table structure for table `tblstudentsubject` */

DROP TABLE IF EXISTS `tblstudentsubject`;

CREATE TABLE `tblstudentsubject` (
  `id` int NOT NULL,
  `stid` int NOT NULL,
  `sid` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_stid` (`stid`),
  KEY `fk_sid` (`sid`),
  CONSTRAINT `fk_sid` FOREIGN KEY (`sid`) REFERENCES `tblsubject` (`id`) ON DELETE CASCADE,
  CONSTRAINT `fk_stid` FOREIGN KEY (`stid`) REFERENCES `tblstudent` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tblstudentsubject` */

/*Table structure for table `tblstudentusers` */

DROP TABLE IF EXISTS `tblstudentusers`;

CREATE TABLE `tblstudentusers` (
  `id` int NOT NULL AUTO_INCREMENT,
  `studentid` varchar(10) NOT NULL,
  `password` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `stid` (`studentid`),
  CONSTRAINT `tblstudentusers_ibfk_1` FOREIGN KEY (`studentid`) REFERENCES `tblstudent` (`studentid`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tblstudentusers` */

insert  into `tblstudentusers`(`id`,`studentid`,`password`) values 
(3,'123456','qwerty');

/*Table structure for table `tblsubject` */

DROP TABLE IF EXISTS `tblsubject`;

CREATE TABLE `tblsubject` (
  `id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(6) NOT NULL,
  `title` varchar(10) NOT NULL,
  `description` varchar(50) NOT NULL,
  `units` int NOT NULL,
  `level` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `code` (`code`),
  UNIQUE KEY `title` (`title`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tblsubject` */

insert  into `tblsubject`(`id`,`code`,`title`,`description`,`units`,`level`) values 
(1,'1923','CCE 103/L','Data Structures and Algorithms',3,'2nd Year: First Semester'),
(2,'1793','CSE 10','CS Professional Elective 2',3,'3rd Year: First Semester'),
(3,'1792','CSE 7','CS Professional Elective 1',3,'3rd Year: First Semester'),
(4,'1795','BSM 325','Numerical Analysis',3,'3rd Year: First Semester'),
(5,'1796','CS 12','Software Engineering 1',3,'3rd Year: Second Semester'),
(6,'1797','CST 9','CS Professional Track 3',3,'3rd Year: Second Semester'),
(7,'1799','Phys 101','College Physics 1',4,'3rd Year: Second Semester');

/*Table structure for table `tbltransaction` */

DROP TABLE IF EXISTS `tbltransaction`;

CREATE TABLE `tbltransaction` (
  `id` int NOT NULL AUTO_INCREMENT,
  `stid` int NOT NULL,
  `description` varchar(100) NOT NULL,
  `amount` int NOT NULL,
  `transactiondate` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_transactionStid` (`stid`),
  CONSTRAINT `fk_transactionStid` FOREIGN KEY (`stid`) REFERENCES `tblstudent` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `tbltransaction` */

/* Procedure structure for procedure `prcGetName` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcGetName` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcGetName`(p_id varchar(10))
BEGIN
		select 
			concat(lastname,", ", firstname," ",left(middlename, 1),".") as fullname
		from
			tblstudent
		where 
			studentid = p_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `prcLogin` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcLogin` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcLogin`(p_id varchar(10), p_password varchar(20))
BEGIN
		select studentid, password from `tblstudentusers` where studentid = p_id and password = p_password;
	END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
