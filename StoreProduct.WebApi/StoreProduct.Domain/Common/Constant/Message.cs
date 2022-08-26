﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProduct.Domain.Common.Constant
{
    public class Message
    {
        #region General
        public readonly static dynamic Successful = new
        {
            ViMessage = "Thành công",
            EnMessage = "Successful"
        };
        public readonly static dynamic Bad_Request = new
        {
            ViMessage = "Có lỗi trong quá trình xử lý",
            EnMessage = "There was an error in processing"
        };
        #endregion General

        #region Account
        public readonly static dynamic LOGIN_ERROR = new
        {
            ViMessage = "Thông tin đăng nhập chưa đúng",
            EnMessage = "Login information is incorrect"
        };
        #endregion Account
    }
}
