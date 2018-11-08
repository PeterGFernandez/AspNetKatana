// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Microsoft.Owin.Security.OpenIdConnect
{
    /// <summary>
    /// State Exception Class.
    /// </summary>
    [ComVisible(true)]
    [Serializable]
    public class StateException : InvalidOperationException
    {
        /// <summary>
        ///     Initializes a new instance of the StateException class.
        /// </summary>
        public StateException()
        {
            return;
        }

        /// <summary>
        ///     Initializes a new instance of the StateException class with
        ///     a specified error message.
        /// </summary>
        //
        // Parameters:
        //   message:
        //     The message that describes the error.
        public StateException(string message) : base(message)
        {
            return;
        }

        /// <summary>
        ///     Initializes a new instance of the System.InvalidOperationException class with
        ///     a specified error message and a reference to the inner exception that is the
        ///     cause of this exception.
        /// </summary>
        //
        // Parameters:
        //   message:
        //     The error message that explains the reason for the exception.
        //
        //   innerException:
        //     The exception that is the cause of the current exception. If the innerException
        //     parameter is not a null reference (Nothing in Visual Basic), the current exception
        //     is raised in a catch block that handles the inner exception.
        public StateException(string message, Exception innerException) : base(message, innerException)
        {
            return;
        }

        /// <summary>
        ///     Initializes a new instance of the System.InvalidOperationException class with
        ///     serialized data.
        /// </summary>
        //
        // Parameters:
        //   info:
        //     The object that holds the serialized object data.
        //
        //   context:
        //     The contextual information about the source or destination.
        protected StateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            return;
        }
    }
}
