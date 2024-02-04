#include "pch.h"
#include "HashBase.h"
#include "Keccak_256.h"

Tuldok::Hash::Keccak_256::Keccak_256() : HashBase(new CryptoPP::Keccak_256())
{
}
