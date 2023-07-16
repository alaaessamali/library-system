/*DDL */
create database Library
CREATE TABLE userTable
(
  id INT NOT NULL,
  account varchar(30) NOT NULL,
  name_ varchar(50) NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (account) REFERENCES userTable(profileTable),
);

CREATE TABLE profileTable
(
  userName varchar(50) NOT NULL,
  UserPssword varchar(50) NOT NULL,
  id INT NOT NULL,
  PRIMARY KEY (userName),
  FOREIGN KEY (id) REFERENCES userTable(id),
  
);

CREATE TABLE Reader
(
  num_of_books INT NOT NULL,
  reader_Address varchar(100) NOT NULL,
  job varchar(60) NOT NULL,
  company varchar(60) NOT NULL,
  id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (id) REFERENCES userTable(id)
);

CREATE TABLE adminTable
(
  position varchar(100) NOT NULL,
  id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (id) REFERENCES userTable(id)
);

CREATE TABLE Document
(
  category varchar(100) NOT NULL,
  availability_No int NOT NULL,
  copy_id INT NOT NULL,
  title varchar(100) NOT NULL,
  price INT NOT NULL,
  Author varchar(100) NOT NULL,
  id INT NOT NULL,
  date_ datetime null,
  PRIMARY KEY (copy_id,id),
  FOREIGN KEY (id) REFERENCES adminTable(id),
);

CREATE TABLE Book
(
  year_ INT  NULL,
  copy_id INT NOT NULL,
  PRIMARY KEY (copy_id),
  FOREIGN KEY (copy_id) REFERENCES Document(copy_id)
);

CREATE TABLE Magazine
(
  editor varchar(60) NOT NULL,
  period_type varchar(60) NOT NULL,
  copy_id INT NOT NULL,
  PRIMARY KEY (copy_id),
  FOREIGN KEY (copy_id) REFERENCES Document(copy_id),
);

CREATE TABLE Buy
(
  Date_ INT NOT NULL,
  Num_of_copies INT NOT NULL,
  id INT NOT NULL,
  copy_id INT NOT NULL,
  PRIMARY KEY (id, copy_id),
  FOREIGN KEY (id) REFERENCES Reader(id),
  FOREIGN KEY (copy_id) REFERENCES Document(copy_id),
);

CREATE TABLE comment
(
  id INT NOT NULL,
  copy_id INT NOT NULL,
  words varchar(8000) null,
  PRIMARY KEY (id, copy_id),
  FOREIGN KEY (id) REFERENCES Reader(student_or_researcher)(id),
  FOREIGN KEY (copy_id) REFERENCES Document(copy_id)
);

CREATE TABLE view_info
(
  id INT NOT NULL,
  copy_id INT NOT NULL,
  PRIMARY KEY (id, copy_id),
  FOREIGN KEY (id) REFERENCES userTable(id),
  FOREIGN KEY (copy_id) REFERENCES Document(copy_id)
);



CREATE TABLE Author
(
  num_of_books INT NOT NULL,
  book_title varchar(100) NOT NULL,
  phone INT NOT NULL,
  id INT NOT NULL,
  copy_id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (id) REFERENCES userTable(id),
  FOREIGN KEY (copy_id) REFERENCES Document(copy_id)
);


/*SQL statment for the first Inquery */

SELECT title 
FROM Document
Where copy_id = (SELECT MAX(copy_id)
                  FROM Document)

/*Second Query*/

SELECT title
FROM  Document
WHERE Document.copy_id = 0 and date__ >=DATEADD(day, -30, getdate())
                            and date__ <= getdate() 


/*query 3*/
Select count(*)
FROM Author 
where copy_id = 0 and date__ >= DATEADD(day, -30, getdate())
                   and date__ <=getdate()

/*query 4*/
select Author
from Author as a, Document as d
where a.copy_id = d.copy_id
    and title = null


/*query 5*/
	SELECT  category, count(*)
	FROM Document 
	GROUP BY category
	HAVING count(*) = Min(count(*))

/*query 6*/
    SELECT num_of_books, job, company,  name_, account
	FROM Reader as r, userTable as u
	WHERE r.id = u.id


	
	
	


