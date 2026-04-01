# GitHub Billing and Payment
비용을 발생하지 않고 사용할 수 있지만 별도로 유료 플랜을 구독하거나, 청구된 제품에 대한 플랜에 포함된 일정 할당량을 초과할 경우 사용량에 대한 비용을 지불해야한다. 자세한 청구 및 소비 보고서를 제공하며 이는 보고서를 통해 비용을 모니터링하고, 리소스를 효율적으로 할당함에 조직 정책을 준수할 수 있다.

* GitHub 요금제
  * 유료 GitHub 계정(Pro, Team)이나 Copilot Plan에 대한 고정 월 요금
* 구독
  * 추가 구독 제품에 대한 고정 월 비용(Ex: GitHub Secret Protection)
* 사용량
  * 요금제에 포함된 금액(GitHub Actions, ...etc)에서 할당된 이상으로 특정 기능을 얼마나 사용하는지에 따라 발생하는 변동 비용이다.

## 청구 방식(Billing work)
각 소유한 계정(Personal, Team, Enterprise)별로 별도로 청구하며 각 계정마다 별도의 청구 항목이 있다.

* 청구 날짜
* GitHub 요금제의 청구 기간(1 Month)
* 결제 수단
  * 신용카드/체크카드(Credit Card)
  * PayPal
  * Azure 구독(Azure Subscription)
  * 영수증(Receipt)

### 청구 주기(Billing Cycle)
계정마다 청구 날짜와 주기가 존재한다. 신용카드 및 PayPal 결제용으로 설정된 개인 및 조직 계정 경우, 청구일은 일반적으로 결제 요금제를 시작한날로 부터 설정한 주기에 맞춰 청구 혹은 결제가 진행된다. 하지만 엔터프라이즈 계정 경우 청구 날짜가 경우에 따라 다를 수 있기에 대부분 사용자는 GitHub Settings에서 Biliing and Payment 카테고리에서 청구 내역을 확인할 수 있다.

> 미터 기반 기능 사용 청구 주기는 월 첫날부터 마지막 날까지 고정된 기간이다.