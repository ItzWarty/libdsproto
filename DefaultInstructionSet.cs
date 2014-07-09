﻿using System;
using Dargon.Transport.ClientImpl;

namespace Dargon.Transport
{
   public class DefaultInstructionSet : IInstructionSet
   {
      public bool UseConstructionContext { get { return false; } }

      /// <summary>
      /// <see cref="IInstructionSet.UseConstructionContext"/>
      /// </summary>
      public object ConstructionContext { get { throw new InvalidOperationException("Construction Context unavailable"); } }

      public Type GetRemotelyInitializedTransactionHandlerType(
         byte opcode)
      {
         switch ((DTP)opcode)
         {
            case DTP.ECHO: return typeof(EchoRith);
            default: return null;
         }
      }
   }
}
