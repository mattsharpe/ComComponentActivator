// dllmain.h : Declaration of module class.

class CSampleComponentModule : public ATL::CAtlDllModuleT< CSampleComponentModule >
{
public :
	DECLARE_LIBID(LIBID_SampleComponentLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_SAMPLECOMPONENT, "{C9BBCC85-D13C-43D2-9FCA-0E48EAB95A14}")
};

extern class CSampleComponentModule _AtlModule;
