//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace BerkeleyDB.Internal {

using global::System;
using global::System.Runtime.InteropServices;

internal class DB_SEQUENCE : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DB_SEQUENCE(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DB_SEQUENCE obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose()  {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
} 

	internal SequenceStatStruct stat(uint flags) {
		int err = 0;
		IntPtr ptr = stat(flags, ref err);
		DatabaseException.ThrowException(err);
		SequenceStatStruct ret = (SequenceStatStruct)Marshal.PtrToStructure(ptr, typeof(SequenceStatStruct));
		libdb_csharp.__os_ufree(null, ptr);
		return ret;
	}

  internal DB_SEQUENCE(DB dbp, uint flags) : this(libdb_csharpPINVOKE.new_DB_SEQUENCE(DB.getCPtr(dbp), flags), true) {
  }

  internal int close(uint flags) {
		int ret = libdb_csharpPINVOKE.DB_SEQUENCE_close(swigCPtr, flags);
		if (ret == 0)
			/* Close is a db handle destructor.  Reflect that in the wrapper class. */
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		else
			DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get(DB_TXN txn, uint delta, ref Int64 retp, uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SEQUENCE_get(swigCPtr, DB_TXN.getCPtr(txn), delta, ref retp, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal DB get_db() {
    global::System.IntPtr cPtr = libdb_csharpPINVOKE.DB_SEQUENCE_get_db(swigCPtr);
    DB ret = (cPtr == global::System.IntPtr.Zero) ? null : new DB(cPtr, false);
    return ret;
  }

  internal int get_key(DatabaseEntry key) {
    try {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SEQUENCE_get_key(swigCPtr, DBT.getCPtr(DatabaseEntry.getDBT(key)));
		DatabaseException.ThrowException(ret);
		return ret;
} finally {
      GC.KeepAlive(key);
    }
  }

  internal int initial_value(Int64 value) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SEQUENCE_initial_value(swigCPtr, value);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int open(DB_TXN txn, DatabaseEntry key, uint flags) {
    try {
	int ret;
	ret = libdb_csharpPINVOKE.DB_SEQUENCE_open(swigCPtr, DB_TXN.getCPtr(txn), DBT.getCPtr(DatabaseEntry.getDBT(key)), flags);
	if (ret != 0)
		close(0);
	DatabaseException.ThrowException(ret);
	return ret;
} finally {
      GC.KeepAlive(key);
    }
  }

  internal int remove(DB_TXN txn, uint flags) {
	int ret;
	ret = libdb_csharpPINVOKE.DB_SEQUENCE_remove(swigCPtr, DB_TXN.getCPtr(txn), flags);
	/* 
	 * remove is a handle destructor, regardless of whether the remove
	 * succeeds.  Reflect that in the wrapper class. 
	 */
	swigCPtr = new HandleRef(null, IntPtr.Zero);
	DatabaseException.ThrowException(ret);
	return ret;
}

  internal int get_cachesize(ref uint size) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SEQUENCE_get_cachesize(swigCPtr, ref size);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_cachesize(uint size) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SEQUENCE_set_cachesize(swigCPtr, size);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_flags(ref uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SEQUENCE_get_flags(swigCPtr, ref flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_flags(uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SEQUENCE_set_flags(swigCPtr, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_range(ref Int64 min, ref Int64 max) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SEQUENCE_get_range(swigCPtr, ref min, ref max);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_range(Int64 min, Int64 max) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SEQUENCE_set_range(swigCPtr, min, max);
		DatabaseException.ThrowException(ret);
		return ret;
}

  private IntPtr stat(uint flags, ref int err) {
	return libdb_csharpPINVOKE.DB_SEQUENCE_stat(swigCPtr, flags, ref err);
}

  internal int stat_print(uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SEQUENCE_stat_print(swigCPtr, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

}

}
