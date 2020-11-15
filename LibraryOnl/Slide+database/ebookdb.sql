create database ebookapp;
use ebookapp;

create table roles(
	id bigint not null primary key identity,
    name varchar(255) not null,
    code varchar(255) not null,
    createddate TIMESTAMP NULL,
	modifieddate TIMESTAMP NULL,
	createdby VARCHAR(255) NULL,
	modifiedby VARCHAR(255) NULL
);

create table users(
	id bigint not null primary key identity,
    username varchar(150) not null,
    password varchar(150) not null,
    fullname varchar(150) not null,
    email varchar(150) null,
    status int not null,
	avattar ntext,
    roleid bigint not null,
    createddate TIMESTAMP NULL,
	modifieddate TIMESTAMP NULL,
	createdby VARCHAR(255) NULL,
	modifiedby VARCHAR(255) NULL
);

ALTER TABLE users ADD CONSTRAINT fk_user_role foreign key(roleid) references roles(id);

CREATE TABLE books (
  id bigint NOT NULL PRIMARY KEY identity,
  title VARCHAR(255) NOT NULL,
  content ntext NOT NULL,
  avattar ntext NOT NULL,
  categoryid bigint NOT NULL,
  createddate TIMESTAMP NULL,
  modifieddate TIMESTAMP NULL,
  createdby VARCHAR(255) NULL,
  modifiedby VARCHAR(255) NULL
);

CREATE TABLE category (
  id bigint NOT NULL PRIMARY KEY identity,
  name VARCHAR(255) NOT NULL,
  code VARCHAR(255) NOT NULL,
  createddate TIMESTAMP NULL,
  modifieddate TIMESTAMP NULL,
  createdby VARCHAR(255) NULL,
  modifiedby VARCHAR(255) NULL
  
);

ALTER TABLE news ADD CONSTRAINT fk_news_category FOREIGN KEY (categoryid) REFERENCES category(id) ON DELETE CASCADE;
