SELECT * FROM CreditCardProcessingMerchantServiceCompany;

INSERT INTO CreditCardProcessingMerchantServiceCompany (CreditCardProcessingMerchantServiceCompanyCode,	CreditCardProcessingMerchantServiceCompanyName) 
VALUES ('1', 'Stax by Fattmerchant'),('2', 'Helcim'),('3', 'Dharma Merchant Servicest'),('4', 'Payment Depot'),('5', 'National Processing'),
('6', 'Block'),('7', 'Intuit Quickbooks'),('8', 'PayPal'),('9', 'Stripe'),('10', 'Flagship Merchant Services'),
('11', 'Clover');

SELECT * FROM CreditCardProcessingMerchantServiceCompany
order by CreditCardProcessingMerchantServiceCompanyCode;


SELECT * FROM CreditCardNetworkCompany;

INSERT INTO CreditCardNetworkCompany (CreditCardNetworkCompanyCode,	CreditCardNetworkCompanyName) 
VALUES ('1', 'American Express'),('2', 'Visa'),('3', 'Mastercard'),('4', 'Discover'),('5', 'Diners Club'),
('6', 'Interlink'),('7', 'Star'),('8', 'Accel'),('9', 'Interac'),('10', 'Visa ReadyLink'),
('11', 'Pulse'),('12', 'JCB (Japan Credit Bureau)'),('13', 'Rupay');

SELECT * FROM CreditCardNetworkCompany
order by CreditCardNetworkCompanyCode;


SELECT * FROM CreditCardIssuingBank;

INSERT INTO CreditCardIssuingBank(CreditCardIssuingBankCode, CreditCardIssuingBankName) 
VALUES ('1', 'American Express'),('2', 'Bank of America'),('3', 'Barclays'),('4', 'Capital One'),('5', 'Chase'),
('6', 'Citi'),('7', 'Discover'),('8', 'Synchrony Bank'),('9', 'U.S. Bank'),('10', 'Wells Fargo');

SELECT * FROM CreditCardIssuingBank
order by CreditCardIssuingBankCode;

SELECT * FROM CreditCardCorporateMerchantBank;

INSERT INTO CreditCardCorporateMerchantBank(CreditCardCorporateMerchantBankCode, CreditCardCorporateMerchantBankName) 
VALUES ('1', 'Chase'),('2', 'Citi'),('3', 'Capital One');

SELECT * FROM CreditCardCorporateMerchantBank
order by CreditCardCorporateMerchantBankCode;

SELECT * FROM CreditCard;

INSERT INTO CreditCard(CreditCardNumber,CreditCardOwnerName,CreditCardProcessingMerchantServiceCompanyCode,CreditCardNetworkCompanyCode,CreditCardIssuingBankCode,
CreditCardCorporateMerchantBankCode,ExpDate,AddressLine1,AddressLine2,City,StateCode,Zipcode,Country,CreditCardLimit,CreditCardAvailableCredit,ActivationStatus) 
VALUES ('1111111111111111','Nathiw Sanchez','1','7','1','3',  '12/31/2023','8 W 118th St','Apt 6D','New York','NY','10026','USA','1500.00','0.00','1'),
	   ('2222222222222221','Cristhian Sanchez', '5','11','5','3' ,'12/31/2025','240 E 109th St','Floor 3','New York','NY','10029','USA','25000.00','500.00','1'),
	   ('2222222222222222','Cristhian Sanchez', '11','3','7','1' ,'12/31/2027','240 E 109th St','Floor 3','New York','NY','10029','USA','15000.00','1684.00','1'),
	   ('2222222222222223','Cristhian Sanchez', '6','1','4','1','12/31/2024','240 E 109th St','Floor 3','New York','NY','10029','USA','35000.00','28483.39','1'),
	   ('3333333333333333','Jayden Nunez','5','1','1','1' ,'12/31/2029','1 W 118th St','Unit 5','New York','NY','10026','USA','8000.00','500.00','1'),
	   ('4444444444444444','Kevin Alvarez', '8','2','3','2'  ,'12/31/2026','96 Madison Ave','Apt 3','Perth Amboy','NJ','08861','USA','5000.00','25.00','1'),
	   ('5555555555555555','Sadie Mirabal',  '9','5','1','1','12/31/2027','96 Madison Ave','Apt 1','Perth Amboy','NJ','08861','USA','5000.00','35.00','1');

SELECT * FROM CreditCard
ORDER BY CreditCardNumber;

SELECT * FROM Country;

SELECT * FROM USState;


/*Testing Side */
SELECT * 
FROM CreditCard 
WHERE CreditCardNumber = '1111111111111111'; 

SELECT CreditCardNumber, CreditCardOwnerName, ExpDate, AddressLine1, AddressLine2, City, StateCode, Zipcode, Country, ActivationStatus
FROM CreditCard WHERE StateCode = 'NJ';

SELECT CREDIT.CreditCardNumber, CREDIT.CreditCardOwnerName, CREDIT.ExpDate, CREDIT.AddressLine1, CREDIT.AddressLine2, CREDIT.City, CREDIT.StateCode, CREDIT.Zipcode,
CREDIT.Country, CREDIT.CreditCardLimit, CREDIT.CreditCardAvailableCredit, CREDIT.ActivationStatus, CreditCardProcessingMerchantServiceCompany.CreditCardProcessingMerchantServiceCompanyName,
    CreditCardNetworkCompany.CreditCardNetworkCompanyName, CreditCardIssuingBank.CreditCardIssuingBankName, CreditCardCorporateMerchantBank.CreditCardCorporateMerchantBankName
FROM CreditCard CREDIT, CreditCardProcessingMerchantServiceCompany, CreditCardNetworkCompany, CreditCardIssuingBank, CreditCardCorporateMerchantBank
WHERE CREDIT.CreditCardProcessingMerchantServiceCompanyCode = CreditCardProcessingMerchantServiceCompany.CreditCardProcessingMerchantServiceCompanyCode
    AND CREDIT.CreditCardNetworkCompanyCode = CreditCardNetworkCompany.CreditCardNetworkCompanyCode
    AND CREDIT.CreditCardIssuingBankCode = CreditCardIssuingBank.CreditCardIssuingBankCode
    AND CREDIT.CreditCardCorporateMerchantBankCode = CreditCardCorporateMerchantBank.CreditCardCorporateMerchantBankCode
	AND CREDIT.CreditCardNumber = '2222222222222221'; 

	SELECT * 
FROM CreditCard ;

SELECT 
    CREDITS.CreditCardNumber,CREDITS.CreditCardOwnerName, CREDITS.ExpDate,CREDITS.AddressLine1,CREDITS.AddressLine2,CREDITS.City,
    CREDITS.StateCode, CREDITS.Zipcode,CREDITS.Country, CREDITS.CreditCardLimit,CREDITS.CreditCardAvailableCredit,CREDITS.ActivationStatus,
    MER.CreditCardProcessingMerchantServiceCompanyName,NET.CreditCardNetworkCompanyName,BANK.CreditCardIssuingBankName, CORP.CreditCardCorporateMerchantBankName
FROM 
    CreditCard CREDITS JOIN 
    CreditCardProcessingMerchantServiceCompany MER ON CREDITS.CreditCardProcessingMerchantServiceCompanyCode = MER.CreditCardProcessingMerchantServiceCompanyCode
JOIN  CreditCardNetworkCompany NET ON CREDITS.CreditCardNetworkCompanyCode = NET.CreditCardNetworkCompanyCode
JOIN CreditCardIssuingBank BANK ON CREDITS.CreditCardIssuingBankCode = BANK.CreditCardIssuingBankCode
JOIN  CreditCardCorporateMerchantBank CORP ON CREDITS.CreditCardCorporateMerchantBankCode = CORP.CreditCardCorporateMerchantBankCode;



UPDATE CreditCard
SET CreditCardOwnerName = 'Joel Robles', CreditCardProcessingMerchantServiceCompanyCode = '2',
CreditCardNetworkCompanyCode = '3', CreditCardIssuingBankCode = '3', CreditCardCorporateMerchantBankCode = '1', 
ExpDate = '2025-07-01', AddressLine1 = '219 E 109th St', AddressLine2 = 'APT 26',
City = 'New York',StateCode= 'NY', Zipcode = '10026', Country= 'USA', CreditCardLimit= '1800.00',
CreditCardAvailableCredit = '0.00', ActivationStatus = '0' WHERE CreditCardNumber = '3333333333333333';

UPDATE CreditCard
SET AddressLine1 = '1100 Franklin Ave', AddressLine2 = 'APT 5B',
City = 'Bronx', StateCode= 'NY', Zipcode = '10456', Country= 'USA'
WHERE CreditCardNumber = '1111111111111111';

INSERT INTO
CreditCard(CreditCardNumber,CreditCardOwnerName,CreditCardProcessingMerchantServiceCompanyCode,CreditCardNetworkCompanyCode,CreditCardIssuingBankCode,
CreditCardCorporateMerchantBankCode,ExpDate,AddressLine1,AddressLine2,City,StateCode,Zipcode,Country,CreditCardLimit,CreditCardAvailableCredit,ActivationStatus)
VALUES ('3333333333333332', 'Joel Roble', '10','6','2','2','10/10/2030','219 E 109th St','Apt 26','New York','NY','10026','USA','1000.00','0.00','1');

DELETE
FROM CreditCard
WHERE CreditCardNumber = '3333333333333332';