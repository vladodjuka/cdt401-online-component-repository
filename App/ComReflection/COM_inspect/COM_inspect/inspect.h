// inspect.h : Declaration of the Cinspect

#pragma once
#include "resource.h"       // main symbols



#include "COM_inspect_i.h"



#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error "Single-threaded COM objects are not properly supported on Windows CE platform, such as the Windows Mobile platforms that do not include full DCOM support. Define _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA to force ATL to support creating single-thread COM object's and allow use of it's single-threaded COM object implementations. The threading model in your rgs file was set to 'Free' as that is the only threading model supported in non DCOM Windows CE platforms."
#endif

using namespace ATL;


// Cinspect

class ATL_NO_VTABLE Cinspect :
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<Cinspect, &CLSID_inspect>,
	public IDispatchImpl<Iinspect, &IID_Iinspect, &LIBID_COM_inspectLib, /*wMajor =*/ 1, /*wMinor =*/ 0>
{
public:
	Cinspect()
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_INSPECT)


BEGIN_COM_MAP(Cinspect)
	COM_INTERFACE_ENTRY(Iinspect)
	COM_INTERFACE_ENTRY(IDispatch)
END_COM_MAP()



	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}

	void FinalRelease()
	{
	}

public:



	STDMETHOD(inspect_component)(BSTR path, BSTR* interfaces, BSTR* classes);
	STDMETHOD(count)(BSTR path, LONG* nb_interfaces, LONG* nb_classes);
};

OBJECT_ENTRY_AUTO(__uuidof(inspect), Cinspect)
