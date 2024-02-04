#pragma once
class HashBase;

namespace Tuldok
{
	namespace Hash
	{
		public ref class Blake2s : HashBase
		{
		public:
			Blake2s();
			Blake2s(uint32_t digestSize);
		};
	}
}

