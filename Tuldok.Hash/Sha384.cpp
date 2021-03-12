#include "pch.h"
#include "HashBase.h"
#include "Sha384.h"

Tuldok::Hash::Sha384::Sha384() : HashBase(new CryptoPP::SHA384())
{

}
