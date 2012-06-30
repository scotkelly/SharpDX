// Copyright (c) 2010-2012 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
#if !WIN8METRO
using System;

namespace SharpDX.Direct3D11
{
    public partial class EffectScalarVariable
    {
        /// <summary>	
        /// Set a floating-point variable.	
        /// </summary>	
        /// <param name="value">A reference to the variable. </param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::SetFloat([None] float Value)</unmanaged>
        public SharpDX.Result Set(float value)
        {
            return SetFloat(value);
        }

        /// <summary>	
        /// Set an array of floating-point variables.	
        /// </summary>	
        /// <param name="dataRef">A reference to the start of the data to set. </param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::SetFloatArray([In, Buffer] float* pData,[None] int Offset,[None] int Count)</unmanaged>
        public SharpDX.Result Set(float[] dataRef)
        {
            return Set(dataRef, 0);
        }

        /// <summary>	
        /// Set an array of floating-point variables.	
        /// </summary>	
        /// <param name="dataRef">A reference to the start of the data to set. </param>
        /// <param name="offset">Must be set to 0; this is reserved for future use.  </param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::SetFloatArray([In, Buffer] float* pData,[None] int Offset,[None] int Count)</unmanaged>
        public SharpDX.Result Set(float[] dataRef, int offset)
        {
            return SetFloatArray(dataRef, offset, dataRef.Length);
        }

        /// <summary>	
        /// Get an array of floating-point variables.	
        /// </summary>	
        /// <param name="count">The number of array elements to set. </param>
        /// <returns>Returns an array of floats. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::GetFloatArray([Out, Buffer] float* pData,[None] int Offset,[None] int Count)</unmanaged>
        public float[] GetFloatArray(int count)
        {
            return GetFloatArray(0, count);
        }

        /// <summary>	
        /// Get an array of floating-point variables.	
        /// </summary>	
        /// <param name="offset">Must be set to 0; this is reserved for future use.  </param>
        /// <param name="count">The number of array elements to set. </param>
        /// <returns>Returns an array of floats. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::GetFloatArray([Out, Buffer] float* pData,[None] int Offset,[None] int Count)</unmanaged>
        public float[] GetFloatArray(int offset, int count)
        {
            var temp = new float[count];
            GetFloatArray(temp, offset, count);
            return temp;
        }

        /// <summary>	
        /// Set an integer variable.	
        /// </summary>	
        /// <param name="value">A reference to the variable. </param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::SetInt([None] int Value)</unmanaged>
        public SharpDX.Result Set(int value)
        {
            return SetInt(value);
        }

        /// <summary>	
        /// Set an array of integer variables.	
        /// </summary>	
        /// <param name="dataRef">A reference to the start of the data to set. </param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::SetIntArray([In, Buffer] int* pData,[None] int Offset,[None] int Count)</unmanaged>
        public SharpDX.Result Set(int[] dataRef)
        {
            return Set(dataRef, 0);
        }

        /// <summary>	
        /// Set an array of integer variables.	
        /// </summary>	
        /// <param name="dataRef">A reference to the start of the data to set. </param>
        /// <param name="offset">Must be set to 0; this is reserved for future use.  </param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::SetIntArray([In, Buffer] int* pData,[None] int Offset,[None] int Count)</unmanaged>
        public SharpDX.Result Set(int[] dataRef, int offset)
        {
            return SetIntArray(dataRef, offset, dataRef.Length);
        }

        /// <summary>	
        /// Get an array of integer variables.	
        /// </summary>	
        /// <param name="count">The number of array elements to set. </param>
        /// <returns>Returns an array of integer variables. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::GetIntArray([Out, Buffer] int* pData,[None] int Offset,[None] int Count)</unmanaged>
        public int[] GetIntArray(int count)
        {
            return GetIntArray(0, count);
        }

        /// <summary>	
        /// Get an array of integer variables.	
        /// </summary>	
        /// <param name="offset">Must be set to 0; this is reserved for future use.  </param>
        /// <param name="count">The number of array elements to set. </param>
        /// <returns>Returns an array of integer variables. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::GetIntArray([Out, Buffer] int* pData,[None] int Offset,[None] int Count)</unmanaged>
        public int[] GetIntArray(int offset, int count)
        {
            var temp = new int[count];
            GetIntArray(temp, offset, count);
            return temp;
        }

        /// <summary>	
        /// Set a boolean variable.	
        /// </summary>	
        /// <param name="value">A reference to the variable. </param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::SetBool([None] BOOL Value)</unmanaged>
        public SharpDX.Result Set(bool value)
        {
            return SetBool(value);
        }

        /// <summary>	
        /// Get a boolean variable.	
        /// </summary>	
        /// <returns>Returns a boolean. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::GetBool([Out] BOOL* pValue)</unmanaged>
        public bool GetBool()
        {
            bool temp;
            GetBool(out temp);
            return temp;
        }

        /// <summary>	
        /// Set an array of boolean variables.	
        /// </summary>	
        /// <param name="dataRef">A reference to the start of the data to set. </param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::SetBoolArray([In, Buffer] BOOL* pData,[None] int Offset,[None] int Count)</unmanaged>
        public SharpDX.Result Set(bool[] dataRef)
        {
            return Set(dataRef, 0);
        }

        /// <summary>	
        /// Set an array of boolean variables.	
        /// </summary>	
        /// <param name="dataRef">A reference to the start of the data to set. </param>
        /// <param name="offset">Must be set to 0; this is reserved for future use.  </param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::SetBoolArray([In, Buffer] BOOL* pData,[None] int Offset,[None] int Count)</unmanaged>
        public SharpDX.Result Set(bool[] dataRef, int offset)        
        {
            return SetBoolArray(Utilities.ConvertToIntArray(dataRef), offset, dataRef.Length);
        }

        /// <summary>	
        /// Get an array of boolean variables.	
        /// </summary>	
        /// <param name="offset">Must be set to 0; this is reserved for future use.  </param>
        /// <param name="count">The number of array elements to set. </param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}. </returns>
        /// <unmanaged>HRESULT ID3D10EffectScalarVariable::GetBoolArray([Out, Buffer] BOOL* pData,[None] int Offset,[None] int Count)</unmanaged>
        public bool[] GetBoolArray(int offset, int count)
        {
            int[] temp = new int[count];
            GetBoolArray(temp, offset, count);
            return Utilities.ConvertToBoolArray(temp);
        }        
    }
}
#endif