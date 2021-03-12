#include "pch.h"
#include "HashBase.h"
#include "Crc32.h"

using namespace CryptoPP;

Tuldok::Hash::Crc32::Crc32() : HashBase(new CRC32())
{
}
