// Test.cpp : Implementation of CTest

#include "stdafx.h"
#include "Test.h"


// CTest

HRESULT CTest::Activate()
{
	HRESULT hr = GetObjectContext(&m_spObjectContext);
	if (SUCCEEDED(hr))
		return S_OK;
	return hr;
} 

BOOL CTest::CanBePooled()
{
	return FALSE;
} 

void CTest::Deactivate()
{
	m_spObjectContext.Release();
} 




STDMETHODIMP CTest::DoSomething(void)
{
	// TODO: Add your implementation code here

	return S_OK;
}
