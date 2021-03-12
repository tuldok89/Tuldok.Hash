#pragma once

class CryptoPP::HashTransformation;

namespace Tuldok
{
	namespace Hash
	{
		public ref class HashBase abstract: System::Security::Cryptography::HashAlgorithm
		{
		public:
			HashBase(CryptoPP::HashTransformation* hasher);
			virtual void Initialize() override;
			virtual ~HashBase();
			virtual property int HashSize
			{
				virtual int get() override;
			}
		protected:
			virtual void HashCore(array<unsigned char, 1>^ array, int ibStart, int cbSize) override;
			virtual array<unsigned char, 1>^ HashFinal() override;
			!HashBase();
		private:
			CryptoPP::HashTransformation* _hasher;
		};
	}
}

