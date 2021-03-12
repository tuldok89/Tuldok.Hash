#include "pch.h"
#include "HashBase.h"
#include "Sha256.h"

using namespace CryptoPP;

Tuldok::Hash::Sha256::Sha256() : HashBase(new SHA256())
{

}
