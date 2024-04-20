#include "EOSSDK-Win64-Shipping_native.h"

DNNE_EXTERN_C DNNE_API uint64_t DNNE_CALLTYPE_STDCALL TESTAddNotify(uint32_t _number, intptr_t cdelegate)
{
	return _TESTAddNotify(_number, cdelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL TESTTriggerNotify(intptr_t cdelegate)
{
	_TESTTriggerNotify(cdelegate);
}

DNNE_EXTERN_C DNNE_API void DNNE_CALLTYPE_STDCALL TESTRemoveNotify(uint64_t id)
{
	_TESTRemoveNotify(id);
}