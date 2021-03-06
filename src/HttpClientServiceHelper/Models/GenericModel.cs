﻿namespace HttpClientServiceHelper.Models
{
    public class GenericModel<T>
    {
        public int StatusCode { get; set; }

        public T Response { get; set; }

        public string ErrorMessage { get; set; }
    }
}
