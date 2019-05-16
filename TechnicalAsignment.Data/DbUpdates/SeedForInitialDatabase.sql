INSERT INTO	Customers (Id, [Name], Email, Mobile)
VALUES ('1234567899', 'Volodymyr', 'volodymyr@gmail.com', NULL),
       ('1234567898', 'Vasyl', 'vasyl@gmail.com', '097989873'),
       ('1234567897', 'Petro', 'petro@gmail.com', '097911111');	

INSERT INTO Transactions (CustomerId, [Date], Amount, CurrencyCode, [Status])
VALUES ('1234567899', '2008-11-11 13:23:44', 10.12, 'UAH', 0),
       ('1234567899', '2012-11-11 13:23:44', 122.98, 'USD', 1),
       ('1234567898', '2019-10-10 19:11:32', 258785.25, 'THB', 0);