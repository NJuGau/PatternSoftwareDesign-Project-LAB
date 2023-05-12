﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService_LAB.ado_model;
using WebService_LAB.repository;

namespace WebService_LAB.handler
{
    public class TransactionDetailHandler
    {
        public static void createTransactionDetail(int transactionID, int albumID, int qty)
        {
            TransactionDetailRepository.createTransactionDetail(transactionID, albumID, qty);
        }

        public static List<TransactionDetail> getDetail(int transactionID)
        {
            return TransactionDetailRepository.getDetail(transactionID);
        }
    }
}