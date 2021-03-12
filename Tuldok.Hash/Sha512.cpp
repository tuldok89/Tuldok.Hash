#include "pch.h"
#include "HashBase.h"
#include "Sha512.h"

using namespace CryptoPP;

Tuldok::Hash::Sha512::Sha512() : HashBase(new SHA512())
{
	
}
