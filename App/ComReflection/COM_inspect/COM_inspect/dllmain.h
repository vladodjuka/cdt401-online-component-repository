// dllmain.h : Declaration of module class.

class CCOM_inspectModule : public ATL::CAtlDllModuleT< CCOM_inspectModule >
{
public :
	DECLARE_LIBID(LIBID_COM_inspectLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_COM_INSPECT, "{00DD60EA-CEB8-4FDF-A0E7-5FF5D1303D78}")
};

extern class CCOM_inspectModule _AtlModule;
