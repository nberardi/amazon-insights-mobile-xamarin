BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild

all: AmazonInsights.dll

Apps-SDK.zip:
	@open https://developer.amazon.com/sdk/download/sdk.html

libAmazonInsightsSDK.a: Apps-SDK.zip
	rm -rf Apps-SDK
	unzip Apps-SDK.zip -d ./Apps-SDK
	cp Apps-SDK/iOS/AmazonInsights/AmazonInsightsSDK.framework/Versions/A/AmazonInsightsSDK $@

AmazonInsights.dll: libAmazonInsightsSDK.a
	$(BTOUCH) ApiDefinition.cs libAmazonInsightsSDK.linkwith.cs --out=$@ --link-with=libAmazonInsightsSDK.a,libAmazonInsightsSDK.a

clean:
	rm -rf bin obj *.a *.dll *.zip
	rm -rf Apps-SDK