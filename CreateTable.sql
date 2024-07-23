CREATE DATABASE EZRENTAL

CREATE TABLE CreditCardProcessingMerchantServiceCompany (
    CreditCardProcessingMerchantServiceCompanyCode TINYINT PRIMARY KEY,
    CreditCardProcessingMerchantServiceCompanyName VARCHAR(60) NOT NULL UNIQUE,
    CHECK (CreditCardProcessingMerchantServiceCompanyCode between 1 and 25)
);

CREATE TABLE CreditCardNetworkCompany (
    CreditCardNetworkCompanyCode TINYINT PRIMARY KEY,
    CreditCardNetworkCompanyName VARCHAR(50) NOT NULL UNIQUE,
    CHECK (CreditCardNetworkCompanyCode between 1 and 25)
);

CREATE TABLE CreditCardIssuingBank (
    CreditCardIssuingBankCode TINYINT PRIMARY KEY,
    CreditCardIssuingBankName VARCHAR(25) NOT NULL UNIQUE,
    CHECK (CreditCardIssuingBankCode between 1 and 25)
);

CREATE TABLE CreditCardCorporateMerchantBank (
    CreditCardCorporateMerchantBankCode TINYINT PRIMARY KEY,
    CreditCardCorporateMerchantBankName VARCHAR(20) NOT NULL UNIQUE,
    CHECK (CreditCardCorporateMerchantBankCode between 1 and 10)
);

CREATE TABLE CreditCard (
    CreditCardNumber VARCHAR(16) PRIMARY KEY,
    CreditCardOwnerName VARCHAR(100) NOT NULL,
    CreditCardProcessingMerchantServiceCompanyCode TINYINT NOT NULL,
    CreditCardNetworkCompanyCode TINYINT NOT NULL,
    CreditCardIssuingBankCode TINYINT NOT NULL,
    CreditCardCorporateMerchantBankCode TINYINT NOT NULL,
    ExpDate DATE NOT NULL,
    AddressLine1 VARCHAR(50) NOT NULL,
    AddressLine2 VARCHAR(50) NULL,
    City VARCHAR(50) NOT NULL,
    StateCode CHAR(2) NOT NULL,
    Zipcode VARCHAR(10) NOT NULL,
	Country VARCHAR(100) NOT NULL,
	CreditCardLimit DECIMAL(8,2) NOT NULL,
	CreditCardAvailableCredit DECIMAL(8,2) NOT NULL,
	ActivationStatus BIT NOT NULL,
    CONSTRAINT FK_CreditCard_ProcessingMerchantServiceCompany
        FOREIGN KEY (CreditCardProcessingMerchantServiceCompanyCode)
        REFERENCES CreditCardProcessingMerchantServiceCompany(CreditCardProcessingMerchantServiceCompanyCode)
		ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_CreditCard_NetworkCompany
        FOREIGN KEY (CreditCardNetworkCompanyCode)
        REFERENCES CreditCardNetworkCompany(CreditCardNetworkCompanyCode)
		ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_CreditCard_IssuingBank
        FOREIGN KEY (CreditCardIssuingBankCode)
        REFERENCES CreditCardIssuingBank(CreditCardIssuingBankCode)
		ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_CreditCard_CorporateMerchantBank
        FOREIGN KEY (CreditCardCorporateMerchantBankCode)
        REFERENCES CreditCardCorporateMerchantBank(CreditCardCorporateMerchantBankCode)
		ON DELETE CASCADE ON UPDATE CASCADE,
     CHECK (CreditCardProcessingMerchantServiceCompanyCode between 1 and 25),
	 CHECK (CreditCardNetworkCompanyCode between 1 and 25),
	 CHECK (CreditCardIssuingBankCode between 1 and 25),
	 CHECK (CreditCardCorporateMerchantBankCode between 1 and 10)
);

CREATE TABLE Country (
    CountryID TINYINT PRIMARY KEY,
	CountryCode2Char CHAR(2) NOT NULL UNIQUE,
	CountryCode3Char CHAR(3) NOT NULL UNIQUE,
    CountryName VARCHAR(100) NOT NULL UNIQUE,
	CHECK (CountryID between 1 and 250)
);

CREATE TABLE USState (
    StateID TINYINT PRIMARY KEY,
    StateCode2Char CHAR(2) NOT NULL UNIQUE,
    StateName VARCHAR(50) NOT NULL UNIQUE,
	CHECK (StateID between 1 and 75)
);

